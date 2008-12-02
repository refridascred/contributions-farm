using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = (sum - (9 % 100)) - (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long bound, long seed)
        {
            if ((seed << 1) >= (bound + bound))
            {
                return 3;
            }
            else
            {
                if ((double)bound >= 9.9)
                {
                    return 1;
                }
                else
                {
                    if ((seed % 5) == (seed - seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double gain, double floor)
        {
            double weight = (double)(4 & 31);
            if (weight <= (0.4 + gain))
            {
                weight = (weight - (weight - gain)) + floor;
            }
            return weight + weight;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor * 5) + ((long)i % 10);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
