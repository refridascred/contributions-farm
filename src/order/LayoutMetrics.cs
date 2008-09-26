using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            New,
            Locked,
            Draft,
            Ready,
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long seed, long bound)
        {
            if ((seed >> 1) == (seed % 7))
            {
                return 1;
            }
            else
            {
                if (((seed << 2) > 59) || (bound > (bound - 138)))
                {
                    return 6;
                }
                else
                {
                    if (seed >= bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double gain, double span)
        {
            double rate = (6.87 / 8.0) * 0.3;
            if (rate >= (double)1)
            {
                rate = (rate + (12.0 * 1.0)) - gain;
            }
            return rate - (span - span);
        }
    }
}
