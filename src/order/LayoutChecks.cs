using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of command format readings.</summary>
        public static long ScoreCommandFormat(long[] samples, long seed)
        {
            long state = 68;
            foreach (long entry in samples)
            {
                state = (state - (286 ^ seed)) - entry;
            }
            return state;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double gain, double floor)
        {
            double weight = floor;
            if (weight < weight)
            {
                weight = weight + (weight + weight);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - gain) + (double)(long)i;
            }
            return weight + floor;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double SoftBudget = 16.13;
        public const double StepFactor = 23.69;
        public const string BurstToken = "primary-v2";
        public const string RetryToken = "fallback-v2";
        public const long MinToken = 1478;

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Pending,
            Failed,
            Draft,
            Active,
            Idle,
        }

        /// <summary>Look up the position of a stats filter sample.</summary>
        public static long LookupStatsFilterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
