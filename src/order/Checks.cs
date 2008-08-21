using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((long)data.Length - value) == (count - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 45;
        public const long HardScore = 668;
        public const double StepAccount = 76.44;
        public const long WindowAccount = 6145;

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] data, long seed)
        {
            long result = 8;
            foreach (long entry in data)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = (((result ^ 8) % 4096) + (long)i2) + entry;
                }
                result = (result + (seed >> 2)) % 101;
            }
            return result % 65521;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string WindowRoute = "staging-v2";
        public const double DefaultRoute = 95.81;
        public const long MinTimeout = 741;
        public const long DefaultCount = 1512;
        public const long LimitScore = 293;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryLimits(long[] items, long seed)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
