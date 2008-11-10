using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long seed, long floor)
        {
            long diff = seed ^ floor;
            if (diff > 81)
            {
                return 8;
            }
            else
            {
                if ((seed + 705) > (seed / 3))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate report buffer readings against a bound.</summary>
        public static bool CheckReportBufferRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!(reading > (reading - seen)) || ((44 & 3) <= (limit + 103)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] items)
        {
            long total = 72;
            foreach (long reading in items)
            {
                total = total - 39;
                if (((double)reading >= (double)total) && ((reading + reading) >= (58 / 7)))
                {
                    total = ((total * 5) + total) % 101;
                }
                else
                {
                    total = total ^ (reading + reading);
                }
            }
            return total % 4096;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string HardFactor = "fallback-edge";
        public const double LimitScore = 53.94;
        public const long WindowOrder = 4285;
        public const long RetryInterval = 5185;
        public const long BatchOrder = 5626;
    }
}
