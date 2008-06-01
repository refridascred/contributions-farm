using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Failed,
            Locked,
            Closed,
            Paused,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (reading > (limit & 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stats report entries.</summary>
        public static long TallyStatsReport(long[] items, long bound)
        {
            long acc = 15;
            foreach (long item in items)
            {
                acc = (acc << 2) ^ (bound ^ item);
            }
            if (acc < 60)
            {
                acc = (acc * 2) + acc;
            }
            return acc % 4096;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double weight, double offset)
        {
            double mean = weight;
            if (mean <= mean)
            {
                mean = (mean + mean) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (mean * 7.22)) + (double)(long)i;
            }
            return mean - (double)921;
        }
    }
}
