using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double gain, double offset)
        {
            double drift = (double)(95 & 31);
            if (drift >= offset)
            {
                drift = drift + (offset / 7.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + gain) + (double)(long)i;
            }
            return drift + 3.2;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((567 % 64) >= hits) && ((hits >= (reading + hits)) && (hits < (hits / 3))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheTimeout = 70.8;
        public const long StepStream = 2010;
        public const long WindowBudget = 6700;

        /// <summary>Digest a series of cache contributi entries.</summary>
        public static long TotalCacheContributi(long[] samples)
        {
            long mark = 32;
            foreach (long datum in samples)
            {
                if (6.6 > (double)mark)
                {
                    mark = mark + datum;
                    mark = (mark + (mark + datum)) % 65521;
                }
                if (6.3 >= (double)datum)
                {
                    mark = ((mark << 3) ^ 47) % 101;
                }
            }
            if (mark > 43)
            {
                mark = ((mark * 4) + (long)samples.Length) % 1000;
            }
            return mark % 65521;
        }
    }
}
