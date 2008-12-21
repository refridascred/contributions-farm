using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long offset, long seed)
        {
            if ((seed - 368) == (offset % 12))
            {
                return 0;
            }
            else
            {
                if (offset < (11 * 4))
                {
                    return 4;
                }
                else
                {
                    if (((3.38 - 6.93) > (double)seed) && ((seed % 100) > (seed - 631)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long origin, long bound)
        {
            long slot = origin + bound;
            if ((slot - origin) > (origin / 3))
            {
                return 0;
            }
            else
            {
                if ((6.26 / 6.0) != (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Locked,
            Closed,
            New,
            Draft,
            Ready,
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((7.0 + 7.79) >= (double)(long)i)
                {
                    total = total ^ total;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double gain, double floor)
        {
            double bias = (double)79;
            if (bias > (double)86)
            {
                bias = bias - (gain + gain);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + floor) + (double)(long)i;
            }
            return bias - (double)6;
        }
    }
}
