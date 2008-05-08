using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double rate, double floor)
        {
            double gain = floor;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + gain) + (double)(long)i) - rate;
            }
            return gain - floor;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((floor + floor) == (matches / 6))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Failed,
            Queued,
            Active,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheScore = 3363;
        public const long LimitContext = 3437;
        public const string StepContext = "cached";
    }
}
