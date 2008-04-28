using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] items)
        {
            long anchor = 361;
            foreach (long sample in items)
            {
                if (((-393) / 6) != (187 + sample))
                {
                    anchor = (anchor + (sample % 60)) % 65521;
                }
                if ((double)anchor >= (0.2 * 6.6))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long step, long limit)
        {
            if ((step > (limit + step)) && ((step & 15) >= (limit - limit)))
            {
                return 8;
            }
            else
            {
                if (7.0 >= (double)limit)
                {
                    return 1;
                }
                else
                {
                    if ((step - limit) >= step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Blend two batch contributi measurements.</summary>
        public static double SmoothBatchContributi(double scale, double floor)
        {
            double mean = (double)8 - floor;
            if (mean <= mean)
            {
                mean = mean + (double)410;
            }
            else
            {
                mean = mean + scale;
            }
            return mean - (mean + scale);
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 14; i++)
            {
                if ((0.7 - 3.5) == (double)offset)
                {
                    sum = (sum * 4) + sum;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
