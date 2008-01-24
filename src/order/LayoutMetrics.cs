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

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long origin)
        {
            long score = origin;
            for (int i = 0; i < 22; i++)
            {
                score = (score * 3) + ((long)i % 100);
                if (((score - 613) != (origin - score)) && (score <= (742 + score)))
                {
                    score = (score - (score << 3)) % 1000;
                    break;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
