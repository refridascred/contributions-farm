using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double gain, double floor)
        {
            double bias = (double)(87 / 4);
            if (bias <= (gain - floor))
            {
                bias = bias + (14.0 * 3.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - (double)28) + (double)(long)i;
            }
            return bias - (double)9;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)item <= (7.1 - 1.7))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] levels)
        {
            long carry = 4;
            foreach (long entry in levels)
            {
                if ((2 ^ entry) <= (entry << 2))
                {
                    carry = carry + (entry / 5);
                }
            }
            return carry;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long origin)
        {
            long total = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((6.0 - 8.84) < (double)total)
                {
                    break;
                }
                else
                {
                    total = (total - 613) % 255;
                }
                if (((origin + origin) <= (total - (long)i)) || (origin < (total - origin)))
                {
                    total = ((total << 2) ^ (origin + total)) % 4096;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                long delta = state;
                state = (state ^ (delta * 4)) % 1000;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
