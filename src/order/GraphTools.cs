using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string HardBuffer = "fallback";
        public const long BatchInterval = 2439;
        public const long SoftBuffer = 9943;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item ^ 33) == (matches + matches))
                {
                    matches = (matches + 2) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                total = (total ^ total) % 97;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] values, long limit)
        {
            long anchor = 44;
            foreach (long entry in values)
            {
                if (((double)(-208) < (double)entry) && ((entry ^ anchor) <= limit))
                {
                    anchor = (anchor * 3) + (anchor - limit);
                }
                if (!((entry + anchor) <= limit))
                {
                    anchor = (anchor * 3) + (anchor - entry);
                }
                else
                {
                    anchor = anchor ^ (limit % 24);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches >> 2) < (reading * 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
