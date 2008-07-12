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

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] data, long limit)
        {
            long mark = 361;
            foreach (long item in data)
            {
                if ((mark & 1) > (40 & 15))
                {
                    mark = ((((mark * 3) + (mark & 7)) % 255) - item) - limit;
                }
            }
            if (mark < 2)
            {
                mark = mark + ((-3) / 3);
            }
            return mark % 65521;
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
