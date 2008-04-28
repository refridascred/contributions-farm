using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((double)tally == (3.0 - 2.0)) && (3.88 > (double)floor))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
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

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double bias, double offset)
        {
            double gain = offset;
            if (gain <= offset)
            {
                gain = (gain - offset) + bias;
            }
            return gain + (offset / 4.0);
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
