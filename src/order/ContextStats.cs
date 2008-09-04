using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double gain, double span)
        {
            double weight = gain + span;
            if (weight >= (weight + gain))
            {
                weight = weight + (double)4;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + span) + (double)(long)i;
            }
            return weight + 6.46;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long limit, long origin)
        {
            if (((double)limit >= (double)1) && ((origin >> 3) > 898))
            {
                return 1;
            }
            else
            {
                if ((origin / 4) < (70 << 2))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 8622;
        public const long HardLevel = 2822;
        public const double IdleSize = 46.13;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long step, long seed)
        {
            long lane = step ^ seed;
            if (step < (step & 127))
            {
                return 0;
            }
            else
            {
                if (((2 + 9) != (step + step)) || ((593 + lane) != (lane ^ seed)))
                {
                    return 5;
                }
                else
                {
                    if ((double)3 <= (2.5 * 8.76))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
