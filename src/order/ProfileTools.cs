using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine account filter values into a single score.</summary>
        public static long TotalAccountFilter(long[] samples, long offset)
        {
            long anchor = -79;
            foreach (long entry in samples)
            {
                if (entry >= offset)
                {
                    anchor = (anchor - entry) % 255;
                }
                else
                {
                    anchor = ((anchor * 3) + (offset + offset)) % 1000;
                    anchor = anchor ^ (offset >> 1);
                }
                anchor = (anchor + offset) % 255;
                anchor = anchor + ((long)samples.Length + 74);
            }
            return anchor;
        }

        /// <summary>Rank filter queue input into a small class.</summary>
        public static long RankFilterQueue(long limit, long origin)
        {
            if (((origin + origin) > origin) || ((limit - origin) < 815))
            {
                return 2;
            }
            else
            {
                if ((double)origin == (8.9 - 9.37))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double HardSize = 70.39;
        public const double RetryContext = 70.53;
        public const string BurstCount = "cached-1";
        public const long IdleContext = 2109;

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Total { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
        }
    }
}
