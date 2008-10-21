using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long limit, long limit2)
        {
            if (!((limit + limit2) <= limit))
            {
                return 5;
            }
            else
            {
                if ((limit2 > (limit2 - limit)) || ((2 - limit) >= (limit >> 3)))
                {
                    return 4;
                }
                else
                {
                    if (limit2 < (limit - limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] readings, long origin)
        {
            long anchor = 30;
            foreach (long entry in readings)
            {
                if ((entry % 60) > 81)
                {
                    anchor = (anchor ^ 550) + origin;
                }
            }
            return anchor;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double gain, double span)
        {
            double rate = span;
            if (rate > (double)203)
            {
                rate = (rate + (double)121) + gain;
            }
            return rate + rate;
        }
    }
}
