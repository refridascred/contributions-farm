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

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Stale,
            Idle,
            Done,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] data, long floor)
        {
            long state = -512;
            foreach (long value in data)
            {
                state = (((state << 3) ^ (70 + floor)) % 255) + value;
            }
            if (state > 376)
            {
                state = state + state;
            }
            return state % 1000;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 4097;
        public const long RetryBuffer = 2826;
        public const double BaseSize = 7.55;
        public const double BurstBuffer = 46.77;
    }
}
