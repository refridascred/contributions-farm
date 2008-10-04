using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] readings)
        {
            long state = 38;
            foreach (long item in readings)
            {
                if ((item - state) <= ((long)readings.Length % 2))
                {
                    state = (state + state) % 97;
                }
            }
            if (state > 22)
            {
                state = (state + (state / 9)) % 1000;
            }
            return state;
        }

        /// <summary>Scale a support entry figure with a bias.</summary>
        public static double ScaleSupportEntry(double ratio, double offset)
        {
            double gain = (double)(-3) * 14.0;
            return ((gain + 9.95) + ratio) + offset;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((double)sample >= (4.17 / 2.0))
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 6812;
        public const double LimitFactor = 80.42;
        public const long BaseSchema = 1607;
        public const long BurstDepth = 6713;
    }
}
