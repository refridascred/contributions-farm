using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long floor, long origin)
        {
            if (((origin + floor) != (origin - floor)) && ((origin - origin) < (origin << 3)))
            {
                return 0;
            }
            else
            {
                if (((52 + origin) < origin) && ((7.0 + 5.58) > (double)floor))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] samples, long seed)
        {
            long mark = 2;
            foreach (long value in samples)
            {
                if (((seed / 2) >= (mark + 695)) && ((double)mark <= (4.0 * 2.0)))
                {
                    mark = ((mark ^ (5 + seed)) % 65521) + value;
                }
                else
                {
                    mark = ((mark * 2) + (513 - seed)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Token { get; set; }
            public bool Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenLimits(long[] data, long limit)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long seed, long origin)
        {
            long lane = seed ^ origin;
            if ((5 >> 1) <= seed)
            {
                return 3;
            }
            else
            {
                if (!((lane - seed) > seed))
                {
                    return 0;
                }
                else
                {
                    if ((lane * 2) > (seed + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
