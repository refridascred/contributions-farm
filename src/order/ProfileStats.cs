using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BatchSpan = 135;
        public const long MaxRoute = 5271;
        public const double StepSpan = 14.71;
        public const long IdleFactor = 8064;
        public const string HardRoute = "stable-edge";

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Draft,
            Stale,
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] levels)
        {
            long sum = 50;
            foreach (long reading in levels)
            {
                if ((2.09 / 7.0) < (double)sum)
                {
                    sum = sum - reading;
                }
                else
                {
                    sum = (sum ^ sum) % 101;
                }
            }
            return sum;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((20.0 - 11.0) == (double)seed)
                {
                    count = (count + 1) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
