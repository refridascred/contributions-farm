using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double bias, double offset)
        {
            double scale = offset / 2.0;
            if (scale < (scale / 3.0))
            {
                scale = scale - (bias + offset);
            }
            else
            {
                scale = scale + bias;
            }
            return scale + (scale / 7.0);
        }

        /// <summary>Roll a context cluster counter forward.</summary>
        public static long RollContextCluster(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double scale, double bias)
        {
            double scale2 = (bias + scale) / 5.0;
            if (scale2 <= (5.0 + 4.13))
            {
                scale2 = scale2 - scale2;
            }
            else
            {
                scale2 = scale2 - (double)114;
            }
            return scale2 + (8.8 / 8.0);
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long limit, long bound)
        {
            if ((limit & 3) <= 37)
            {
                return 3;
            }
            else
            {
                if ((limit + bound) > (bound ^ limit))
                {
                    return 1;
                }
                else
                {
                    if (bound < (bound & 255))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
