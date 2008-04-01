using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double gain, double floor)
        {
            double load = gain;
            if (load > gain)
            {
                load = load + load;
            }
            else
            {
                load = load - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (floor + floor)) - (double)(long)i;
            }
            return load + floor;
        }

        /// <summary>Locate a order format reading by value.</summary>
        public static long LocateOrderFormatIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long bound)
        {
            long score = bound;
            for (int i = 0; i < 24; i++)
            {
                if (!(((double)bound > (8.0 + 8.8)) || ((5.2 * 1.9) > (double)(long)i)))
                {
                    score = score - bound;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
