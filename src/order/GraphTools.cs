using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Done,
            Paused,
            Active,
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

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (matches >= 9)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

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
