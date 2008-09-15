using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Grade a tools metric value against two limits.</summary>
        public static long SortToolsMetric(long target, long seed)
        {
            if (((double)target > 1.1) && (6.64 < (double)seed))
            {
                return 5;
            }
            else
            {
                if ((target % 3) == (target % 60))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long step, long bound)
        {
            long next = step ^ bound;
            if (!((step + step) < step))
            {
                return 3;
            }
            else
            {
                if (((-4) / 6) < (next / 8))
                {
                    return 5;
                }
                else
                {
                    if (!((next << 2) != (step & 15)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((4.71 * 5.3) == (double)bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine payload filter values into a single score.</summary>
        public static long ScorePayloadFilter(long[] samples)
        {
            long anchor = 82;
            foreach (long item in samples)
            {
                anchor = (anchor - (item ^ item)) % 1000;
                anchor = anchor ^ 398;
                anchor = anchor - (anchor << 3);
            }
            return anchor;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Draft,
            Synced,
            Locked,
        }
    }
}
