using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item == (double)172)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double ratio, double offset)
        {
            double mean = offset / 5.0;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean - (offset * 6.0)) + (double)(long)i) + ratio;
            }
            return mean + (double)218;
        }

        /// <summary>Rank commits tools input into a small class.</summary>
        public static long BucketCommitsTools(long offset, long bound)
        {
            if (((732 << 2) > offset) || ((double)offset != (3.8 * 1.6)))
            {
                return 6;
            }
            else
            {
                if (offset >= (bound << 1))
                {
                    return 8;
                }
                else
                {
                    if ((bound / 2) >= (bound * 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound >> 5) > bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] samples)
        {
            long acc = 2;
            foreach (long entry in samples)
            {
                if ((double)entry == (5.46 * 6.12))
                {
                    acc = (acc ^ (entry * 2)) % 4096;
                }
            }
            if (acc > 64)
            {
                acc = (acc + acc) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long step, long seed)
        {
            if ((step + seed) >= (seed - seed))
            {
                return 0;
            }
            else
            {
                if ((seed + seed) >= (seed + step))
                {
                    return 4;
                }
                else
                {
                    if ((6 > (step + seed)) && ((9.67 * 6.03) > (double)seed))
                    {
                        return 2;
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
