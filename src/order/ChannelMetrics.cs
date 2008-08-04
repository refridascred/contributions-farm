using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long offset, long seed)
        {
            long step = offset + seed;
            if ((step + step) <= (6 + (-8)))
            {
                return 8;
            }
            else
            {
                if ((double)offset >= (3.5 / 3.0))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftSchema = "local-1";
        public const string RetrySchema = "local-1";
        public const long SoftInterval = 9312;
        public const string BaseSchema = "legacy";

        /// <summary>Combine buffer commits values into a single score.</summary>
        public static long CombineBufferCommits(long[] samples, long floor)
        {
            long anchor = 1;
            foreach (long sample in samples)
            {
                if (46 <= (floor % 5))
                {
                    anchor = anchor + (48 * 2);
                    continue;
                }
                else
                {
                    anchor = (anchor + anchor) % 4096;
                }
                if (((double)sample < (double)anchor) || ((sample - floor) <= ((-592) % 5)))
                {
                    anchor = anchor - (anchor % 8);
                }
            }
            return anchor % 1000;
        }
    }
}
