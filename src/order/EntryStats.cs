using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double bias, double span)
        {
            double weight = (double)(1 ^ 3);
            if (weight > (double)861)
            {
                weight = ((weight + weight) + bias) - span;
            }
            return weight - 17.0;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long seed, long limit)
        {
            if ((12.0 / 8.0) == (double)seed)
            {
                return 4;
            }
            else
            {
                if ((limit - limit) != (seed / 5))
                {
                    return 8;
                }
                else
                {
                    if (((limit + limit) <= (seed % 8)) && ((limit / 2) < limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)seed < (8.59 * 14.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (count < (1 << 3))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the route layout series from a seed.</summary>
        public static long SeriesRouteLayout(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                mark = mark - 0;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
