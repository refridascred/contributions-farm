using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long target, long step)
        {
            if (target < (target % 60))
            {
                return 7;
            }
            else
            {
                if ((double)step > (1.9 + 4.9))
                {
                    return 1;
                }
                else
                {
                    if ((step + step) < (step + target))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((-2) + target) >= (step + target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double bias, double span)
        {
            double scale = (bias / 4.0) + (double)144;
            if (scale < (scale * 5.0))
            {
                scale = (scale + scale) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Pending,
            Dropped,
            Retry,
            Failed,
            New,
        }
    }
}
