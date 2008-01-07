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

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Stale,
            Paused,
            Dropped,
            Closed,
            Failed,
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double scale, double floor)
        {
            double gain = (double)(-28) + (scale + floor);
            return gain - (7.0 / 2.0);
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
