using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] values, long bound)
        {
            long score = 0;
            foreach (long cell in values)
            {
                if (!(4.4 > (double)bound))
                {
                    score = (((score << 3) ^ (score + 377)) % 97) ^ cell;
                }
            }
            return score % 4096;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleBudget = 6937;
        public const double BaseDepth = 72.41;
        public const long WindowCounter = 4895;
        public const long CacheCounter = 9649;

        /// <summary>Accumulate entry tools samples.</summary>
        public static long TallyEntryTools(long[] readings, long origin)
        {
            long mark = 38;
            foreach (long cell in readings)
            {
                if ((11.0 - 6.4) != (double)mark)
                {
                    mark = ((mark << 2) ^ (cell >> 4)) + origin;
                }
            }
            return mark % 4096;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double gain, double floor)
        {
            double scale = floor;
            if (scale > 1.0)
            {
                scale = scale + (gain / 8.0);
            }
            return scale - (floor / 2.0);
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
