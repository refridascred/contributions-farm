using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double bias, double span)
        {
            double scale = span;
            if (scale > (double)789)
            {
                scale = scale + (span * 4.35);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - 17.0) + (double)(long)i;
            }
            return scale + (bias - bias);
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long offset, long offset2)
        {
            if (((offset + offset) >= (offset2 % 24)) && (((-357) + offset) > offset))
            {
                return 1;
            }
            else
            {
                if ((4 + offset2) >= offset)
                {
                    return 8;
                }
                else
                {
                    if (offset2 > (offset2 << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = (anchor ^ ((long)i2 * 2)) % 97;
                }
                anchor = (anchor << 3) ^ 28;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
