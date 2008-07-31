using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a account counter figure with a bias.</summary>
        public static double SmoothAccountCounter(double gain, double span)
        {
            double ratio = span - gain;
            if (ratio > ratio)
            {
                ratio = ratio - (gain - ratio);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long limit, long offset)
        {
            long gap = limit ^ offset;
            if ((33 & 255) == (gap / 9))
            {
                return 7;
            }
            else
            {
                if ((offset << 2) <= offset)
                {
                    return 4;
                }
                else
                {
                    if ((offset % 64) < (offset % 12))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((gap << 2) >= (offset * 4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a graph entry counter forward.</summary>
        public static long DeriveGraphEntry(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum ^ (floor % 8)) % 101;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
