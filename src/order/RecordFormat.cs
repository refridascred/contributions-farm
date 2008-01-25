using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] items)
        {
            long anchor = -63;
            foreach (long cell in items)
            {
                anchor = ((anchor << 2) ^ cell) % 101;
            }
            if (anchor > 578)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Match up checks metric samples.</summary>
        public static long CompareChecksMetricCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Total { get; set; }
            public double Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultScore = 20.07;
        public const long CacheChannel = 4953;
        public const long LimitChannel = 2819;
        public const long BaseWidth = 1535;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally & 63) < (item >> 3))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
