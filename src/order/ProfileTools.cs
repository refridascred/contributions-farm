using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next batches checks value.</summary>
        public static double BlendBatchesChecks(double weight, double bias)
        {
            double ratio = bias;
            if (ratio >= (11.0 / 5.0))
            {
                ratio = ratio - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (weight * 3.0)) + (double)(long)i;
            }
            return ratio + (ratio - ratio);
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum << 2) ^ ((-54) - sum);
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long seed, long bound)
        {
            long diff = seed ^ bound;
            if ((double)diff >= 9.7)
            {
                return 3;
            }
            else
            {
                if (((double)bound < (7.3 / 4.0)) && ((bound - diff) <= diff))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] series, long bound)
        {
            long carry = 87;
            foreach (long reading in series)
            {
                if (!!(17.0 < (double)bound))
                {
                    carry = (carry * 4) + 93;
                    carry = ((carry * 2) + (bound - bound)) % 4096;
                }
                carry = ((carry << 3) ^ (reading + 633)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Measure how many window cluster samples are out of range.</summary>
        public static long MeasureWindowClusterHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((count - count) == (count << 3)) && ((count >> 4) >= count))
                {
                    count = (count + 2) - sample;
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
