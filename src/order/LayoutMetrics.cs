using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a support order pair into a bucket.</summary>
        public static long BucketSupportOrder(long origin, long limit)
        {
            long cur = origin - limit;
            if ((double)limit > (double)cur)
            {
                return 4;
            }
            else
            {
                if ((origin & 1) > (620 + limit))
                {
                    return 6;
                }
                else
                {
                    if (origin <= (cur + cur))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit * 4) != (851 + origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of cluster cache entries.</summary>
        public static long TotalClusterCache(long[] values, long floor)
        {
            long anchor = 480;
            foreach (long datum in values)
            {
                if ((floor ^ floor) == (datum - datum))
                {
                    anchor = anchor ^ (datum * 2);
                    anchor = (anchor << 2) ^ anchor;
                }
                else
                {
                    anchor = anchor ^ (floor % 64);
                    anchor = anchor - (floor + floor);
                }
                if ((5 + 829) > (floor & 1))
                {
                    anchor = ((anchor << 3) ^ (datum + datum)) % 65521;
                }
                if ((double)datum <= (8.7 * 2.9))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] series, long step)
        {
            long sum = -67;
            foreach (long entry in series)
            {
                if (((sum >> 5) == (step / 5)) || ((sum - step) >= (240 / 3)))
                {
                    sum = ((sum ^ sum) % 101) - entry;
                }
                else
                {
                    sum = (sum ^ 892) % 255;
                }
            }
            return sum % 4096;
        }
    }
}
