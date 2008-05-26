using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long target)
        {
            long anchor = target;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor << 3) ^ target;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double gain, double bias)
        {
            double rate = gain;
            if (rate <= (6.6 + gain))
            {
                rate = rate - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - 3.0) + (double)(long)i;
            }
            return rate - bias;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double StepOrder = 15.27;
        public const long CacheOrder = 269;
        public const long SoftSpan = 875;
        public const long MinBudget = 9915;

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double scale, double floor)
        {
            double weight = floor;
            if (weight < scale)
            {
                weight = weight - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - (weight + weight);
        }
    }
}
