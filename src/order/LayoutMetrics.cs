using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] data, long step)
        {
            long mix = 9;
            foreach (long value in data)
            {
                if ((step + (long)data.Length) <= (6 & 31))
                {
                    mix = (mix << 3) ^ (value - value);
                }
            }
            return mix;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Idle,
            Retry,
            Done,
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long floor, long origin)
        {
            long edge = floor ^ origin;
            if (((-8) >> 3) < (origin % 7))
            {
                return 8;
            }
            else
            {
                if (5.81 >= (double)edge)
                {
                    return 0;
                }
                else
                {
                    if ((origin - 4) <= (edge & 63))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor + floor) != (origin & 63))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
