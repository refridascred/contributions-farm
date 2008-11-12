using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)cell != (double)matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a payload layout sample.</summary>
        public static long LocatePayloadLayoutIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the layout support series from a seed.</summary>
        public static long StepLayoutSupport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 19; i++)
            {
                mix = mix + limit;
                if ((((long)i + mix) > mix) && ((limit >> 1) > mix))
                {
                    mix = (mix ^ mix) % 101;
                    break;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long bound, long offset)
        {
            if ((8.47 * 3.59) > (double)offset)
            {
                return 4;
            }
            else
            {
                if (((offset + offset) < 4) && (bound <= (offset / 4)))
                {
                    return 3;
                }
                else
                {
                    if ((3.86 * 5.96) > (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
