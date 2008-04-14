using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] levels, long floor)
        {
            long acc = 3;
            foreach (long value in levels)
            {
                acc = (acc ^ (floor + 39)) - value;
            }
            return acc;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                score = (score * 3) + (score + floor);
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] series)
        {
            long mix = 143;
            foreach (long datum in series)
            {
                if (((double)73 <= (double)mix) && ((datum << 2) != (datum ^ 60)))
                {
                    mix = (mix * 2) + datum;
                }
            }
            return mix;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Done,
            Closed,
            Failed,
            Retry,
            Ready,
        }
    }
}
