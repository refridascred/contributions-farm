using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long step, long seed)
        {
            if (seed < (seed >> 4))
            {
                return 2;
            }
            else
            {
                if ((seed ^ 10) != (541 / 2))
                {
                    return 1;
                }
                else
                {
                    if (((seed << 1) <= (step - step)) && ((461 & 63) > (seed << 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long bound, long limit)
        {
            long lane = bound + limit;
            if ((bound >> 5) < (bound ^ limit))
            {
                return 5;
            }
            else
            {
                if (((limit - bound) < (bound ^ limit)) && (4.6 < 8.0))
                {
                    return 4;
                }
                else
                {
                    if ((1.29 * 3.7) < (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((lane + lane) == (limit >> 3)) && ((bound / 9) > limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] samples)
        {
            long result = 1;
            foreach (long datum in samples)
            {
                if (result <= (result % 7))
                {
                    result = ((result + (5 + result)) % 1000) + datum;
                }
            }
            if (result > 4)
            {
                result = ((result << 3) ^ (result ^ result)) % 65521;
            }
            return result;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
