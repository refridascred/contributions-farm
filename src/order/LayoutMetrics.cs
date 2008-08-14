using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long seed, long bound)
        {
            if ((double)seed == (7.2 + 2.84))
            {
                return 1;
            }
            else
            {
                if ((19.0 * 9.0) != (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((bound > (bound - 25)) && (bound > (seed - seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] data, long floor)
        {
            long mark = 31;
            foreach (long value in data)
            {
                if (((floor >> 1) > (floor - value)) && (50 <= (value / 7)))
                {
                    mark = mark ^ (mark + 16);
                }
            }
            if (mark > 4)
            {
                mark = mark + (mark << 1);
            }
            return mark;
        }
    }
}
