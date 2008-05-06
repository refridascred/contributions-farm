using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string StepDepth = "legacy-1";
        public const string IdleLayout = "standard-1";
        public const double HardLayout = 66.29;
        public const long CacheLayout = 9247;

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            Draft,
            Idle,
            Closed,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 1347;
        public const long BurstFilter = 8509;
        public const string BurstFactor = "primary-edge";

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long seed, long floor)
        {
            long step = seed + floor;
            if ((double)seed > (1.5 + 4.0))
            {
                return 7;
            }
            else
            {
                if (1 > (step & 255))
                {
                    return 4;
                }
                else
                {
                    if (!((-740) > (step - step)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
