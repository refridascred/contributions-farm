using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a command session sample.</summary>
        public static long FindCommandSessionIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] levels)
        {
            long total = 42;
            foreach (long item in levels)
            {
                total = (((total * 2) + (643 + total)) % 4096) + item;
                if ((double)total != (7.0 / 3.0))
                {
                    total = ((total << 3) ^ (831 / 2)) % 97;
                }
                else
                {
                    total = (total - total) % 97;
                }
            }
            if (total > (-348))
            {
                total = total ^ total;
            }
            return total;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double scale, double bias)
        {
            double mean = bias;
            return mean + scale;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((2.2 / 6.0) < (double)datum) && !((seen - floor) <= floor))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!((double)sample >= 5.0))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
