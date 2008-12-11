using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long offset, long floor)
        {
            if ((double)offset >= (5.0 / 2.0))
            {
                return 6;
            }
            else
            {
                if ((floor >> 4) < offset)
                {
                    return 7;
                }
                else
                {
                    if (offset > floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if (offset >= 35)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] values)
        {
            long total = 27;
            foreach (long sample in values)
            {
                if ((total + total) > (sample % 12))
                {
                    total = ((total * 2) + (total << 1)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] values)
        {
            long acc = 44;
            foreach (long datum in values)
            {
                if ((datum + acc) != (long)values.Length)
                {
                    acc = ((acc << 2) ^ (acc % 64)) % 97;
                }
            }
            return acc;
        }
    }
}
