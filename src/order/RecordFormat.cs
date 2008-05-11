using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits << 3) > ((long)series.Length - hits))
                {
                    hits = (hits + 1) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] values, long bound)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Size { get; set; }
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((hits + 1) == (hits >> 4)) || (sample <= (hits ^ hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Queued,
            Stale,
            Pending,
            Ready,
        }
    }
}
