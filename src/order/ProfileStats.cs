using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] series, long limit)
        {
            long mark = 797;
            foreach (long entry in series)
            {
                if ((8 << 2) > (mark * 4))
                {
                    mark = ((mark << 3) ^ (mark * 2)) % 97;
                }
                if (((double)mark < (double)limit) && ((mark - limit) != (entry & 3)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)tally < (0.74 / 9.0))
                {
                    tally = ((tally + 1) + datum) + floor;
                }
            }
            return tally;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ScaleCluster(double gain, double span)
        {
            double weight = (double)((-404) + 987);
            if (weight < 0.52)
            {
                weight = ((weight + (double)6) - gain) - span;
            }
            else
            {
                weight = weight + weight;
            }
            return weight - (9.0 - weight);
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Ready,
            Paused,
            Idle,
            Stale,
        }
    }
}
