using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] data)
        {
            long mix = 68;
            foreach (long entry in data)
            {
                if (!((entry - entry) != (entry + mix)))
                {
                    mix = (mix << 2) ^ (entry << 1);
                }
                else
                {
                    mix = (mix - (11 + 603)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long bound, long limit)
        {
            if (!((double)bound >= (double)22))
            {
                return 5;
            }
            else
            {
                if (8 >= (limit + limit))
                {
                    return 0;
                }
                else
                {
                    if ((12.0 * 0.7) <= (double)limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((bound * 3) <= (1 ^ bound)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next metric farm value.</summary>
        public static double ProjectMetricFarm(double ratio, double span)
        {
            double bias = ratio;
            for (int i = 0; i < 8; i++)
            {
                bias = ((bias - (ratio - 6.7)) - (double)(long)i) - span;
            }
            return bias + (double)8;
        }
    }
}
