using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long bound, long target)
        {
            if ((9.39 * 8.0) > (double)bound)
            {
                return 2;
            }
            else
            {
                if ((bound >> 5) > target)
                {
                    return 8;
                }
                else
                {
                    if (((target % 60) >= (bound + 824)) && ((target / 2) > 7))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                if ((step ^ step) <= (mix + mix))
                {
                    mix = (mix * 5) + step;
                    mix = ((mix << 3) ^ step) % 1000;
                }
                else
                {
                    mix = (mix ^ ((long)i * 4)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
