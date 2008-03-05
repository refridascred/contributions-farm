using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] samples, long origin)
        {
            long acc = 5;
            foreach (long datum in samples)
            {
                if ((origin - origin) == (origin + origin))
                {
                    acc = (acc + datum) % 255;
                }
            }
            if (acc > 65)
            {
                acc = ((acc << 2) ^ (acc - (-49))) % 65521;
            }
            return acc;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 8620;
        public const long CacheReport = 1837;
        public const long MinReport = 4611;
        public const long WindowSpan = 1593;

        /// <summary>Iterate the window account series from a seed.</summary>
        public static long IterateWindowAccount(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor ^ anchor) % 4096;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally * 5) >= (tally + tally))
                {
                    tally = ((tally + 2) - item) - offset;
                }
            }
            return tally;
        }
    }
}
