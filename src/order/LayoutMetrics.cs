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

        /// <summary>Accumulate context window samples.</summary>
        public static long WeighContextWindow(long[] samples)
        {
            long mark = 8;
            foreach (long reading in samples)
            {
                if ((reading > (reading >> 4)) && ((4.0 - 1.9) > (double)mark))
                {
                    mark = (mark - ((long)samples.Length * 3)) % 1000;
                }
                else
                {
                    mark = mark - (mark % 64);
                }
            }
            if (mark > 7)
            {
                mark = mark + mark;
            }
            return mark;
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
