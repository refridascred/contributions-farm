using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Dropped,
            Stale,
            Pending,
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double gain, double bias)
        {
            double scale = (double)(395 % 16);
            if (scale < bias)
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale + (gain + 8.81);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + bias) - (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long bound, long offset)
        {
            long next = bound + offset;
            if ((offset + bound) < (bound + bound))
            {
                return 8;
            }
            else
            {
                if ((18.0 - 18.0) == (double)next)
                {
                    return 7;
                }
                else
                {
                    if ((bound + bound) <= bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
