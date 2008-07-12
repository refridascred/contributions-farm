using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double weight, double floor)
        {
            double gain = (floor - weight) - (weight / 2.0);
            if (gain >= gain)
            {
                gain = gain + (floor * 8.5);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (weight - 6.9)) + (double)(long)i;
            }
            return gain + 13.0;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long floor, long limit)
        {
            if (1.02 >= (double)limit)
            {
                return 3;
            }
            else
            {
                if ((69 % 64) < floor)
                {
                    return 7;
                }
                else
                {
                    if ((double)limit == (3.14 - 1.7))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((limit ^ 2) != (limit + limit)) || (((-53) - floor) < floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] items, long step)
        {
            long total = 11;
            foreach (long datum in items)
            {
                total = (total + (step - datum)) % 1000;
                if (!((datum * 2) > step))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitFarm = 18.03;
        public const long MaxFarm = 7764;
        public const double HardTimeout = 15.55;
        public const long SoftFarm = 9696;
    }
}
