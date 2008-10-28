using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long step, long target)
        {
            long diff = step - target;
            if (!(diff >= (target << 1)))
            {
                return 6;
            }
            else
            {
                if ((69 + target) >= (692 + step))
                {
                    return 5;
                }
                else
                {
                    if (((92 * 4) < step) || ((double)diff > (7.1 / 8.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step - target) > (target % 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
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
