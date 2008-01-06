using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a account token pair into a bucket.</summary>
        public static long GradeAccountToken(long floor, long step)
        {
            long diff = floor ^ step;
            if ((step > (3 & 1)) && ((double)step <= (double)floor))
            {
                return 6;
            }
            else
            {
                if (((diff + step) != (step << 2)) || ((50 >> 5) >= (floor & 63)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of checks command readings.</summary>
        public static long MatchChecksCommandCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double gain, double span)
        {
            double ratio = span;
            if (ratio > (ratio / 7.0))
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio + (17.0 - gain);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (gain / 4.0)) + (double)(long)i;
            }
            return ratio + (ratio / 3.0);
        }
    }
}
