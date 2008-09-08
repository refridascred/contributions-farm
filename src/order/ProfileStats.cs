using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheRatio = 6956;
        public const long CacheTools = 8779;
        public const string DefaultTimeout = "stable";

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long limit, long offset)
        {
            long cur = limit + offset;
            if ((double)offset <= (15.0 + 3.0))
            {
                return 0;
            }
            else
            {
                if ((((-7) + 389) >= cur) && ((offset - 237) < 966))
                {
                    return 6;
                }
                else
                {
                    if ((cur * 5) != (cur << 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
