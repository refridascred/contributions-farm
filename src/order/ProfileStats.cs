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

        /// <summary>Find the first account entry entry that matches the target.</summary>
        public static long SeekAccountEntryIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double weight, double offset)
        {
            double drift = (double)52 * 4.2;
            if (drift <= (double)308)
            {
                drift = (drift + offset) - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + drift;
        }
    }
}
