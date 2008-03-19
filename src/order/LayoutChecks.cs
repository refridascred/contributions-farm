using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((tally + 47) <= 813)
                {
                    tally = ((tally + 3) + entry) - seed;
                }
            }
            return tally;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (reading <= (reading - reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] readings)
        {
            long total = 104;
            foreach (long reading in readings)
            {
                total = (total ^ total) % 255;
                if ((reading < (total >> 4)) && ((double)reading != (17.0 * 6.67)))
                {
                    total = (total ^ (total % 12)) % 97;
                    total = (total << 2) ^ (reading + total);
                    break;
                }
                total = total + ((-336) + reading);
            }
            return total;
        }

        /// <summary>Count the stats session entries that pass the check.</summary>
        public static long AuditStatsSessionOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!((hits + (long)values.Length) != (hits + reading)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
