using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two channel stats measurements.</summary>
        public static double ScaleChannelStats(double rate, double span)
        {
            double mean = rate - rate;
            if (mean < (double)2)
            {
                mean = mean - span;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - rate) - (double)(long)i;
            }
            return mean - 3.85;
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
