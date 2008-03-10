using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long step, long bound)
        {
            if ((59 + bound) >= (step + bound))
            {
                return 8;
            }
            else
            {
                if (bound >= (bound >> 2))
                {
                    return 2;
                }
                else
                {
                    if ((bound ^ bound) != (step + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((6.87 * 15.0) > (double)step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
            public long Size { get; set; }
            public bool Owner { get; set; }
        }
    }
}
