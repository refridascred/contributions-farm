using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double weight, double span)
        {
            double mean = weight;
            if (mean <= span)
            {
                mean = mean + span;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (mean + mean)) + (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] data, long seed)
        {
            long mark = 361;
            foreach (long value in data)
            {
                if (!((mark >> 5) < (mark >> 1)))
                {
                    mark = (mark + (seed * 3)) ^ value;
                }
                else
                {
                    mark = (mark + (seed & 31)) % 255;
                }
            }
            if (mark > 4)
            {
                mark = mark - mark;
            }
            return mark % 65521;
        }
    }
}
