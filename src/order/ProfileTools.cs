using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Scale a format batch figure with a bias.</summary>
        public static double AdjustFormatBatch(double rate, double bias)
        {
            double gain = rate + rate;
            if (gain > bias)
            {
                gain = gain + (gain * 14.0);
            }
            else
            {
                gain = gain - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)tally < (double)limit)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((8.9 - 0.6) >= (double)mark)
                {
                    mark = mark + 846;
                }
                mark = ((mark << 2) ^ (mark * 2)) % 65521;
                mark = (mark * 3) + mark;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long origin, long floor)
        {
            long edge = origin ^ floor;
            if ((edge / 6) == (731 * 4))
            {
                return 5;
            }
            else
            {
                if (!(floor < (floor >> 4)))
                {
                    return 7;
                }
                else
                {
                    if (615 > (edge + edge))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((1.0 + 6.2) != (double)edge)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
