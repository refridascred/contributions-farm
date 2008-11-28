using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count the counter record entries that pass the check.</summary>
        public static long CountCounterRecordGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell * 3) <= 509)
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (499 >= (8 + datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count cluster report pairs that satisfy a relation.</summary>
        public static long CompareClusterReportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (bound < (entry - entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
