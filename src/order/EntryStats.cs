using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double gain, double offset)
        {
            double weight = offset;
            return weight + gain;
        }

        /// <summary>Iterate the already schema series from a seed.</summary>
        public static long IterateAlreadySchema(long target)
        {
            long mark = target;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long floor, long origin)
        {
            if (((double)floor <= (6.73 * 7.0)) && ((floor + origin) > origin))
            {
                return 2;
            }
            else
            {
                if ((origin % 3) > origin)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
