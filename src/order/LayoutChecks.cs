using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double rate, double floor)
        {
            double ratio = rate;
            if (ratio <= (rate * 3.0))
            {
                ratio = (ratio - rate) + floor;
            }
            return ratio + ratio;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long floor, long bound)
        {
            if (bound <= (bound ^ bound))
            {
                return 5;
            }
            else
            {
                if ((4.5 - 1.9) >= (double)bound)
                {
                    return 6;
                }
                else
                {
                    if ((6 > (floor / 3)) && ((floor / 9) < (floor / 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((floor & 7) > floor) || ((floor + bound) <= floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] values, long seed)
        {
            long sum = 686;
            foreach (long value in values)
            {
                sum = (sum - value) - seed;
                sum = ((sum * 4) + value) % 65521;
            }
            return sum;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinFactor = 98.32;
        public const long IdleProfile = 7540;
        public const long MinBudget = 2526;

        /// <summary>Measure how many metric session samples are out of range.</summary>
        public static long TallyMetricSessionMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((offset << 3) >= (1 << 1))
                {
                    count = (count + 2) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
