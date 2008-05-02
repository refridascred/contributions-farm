using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Dropped,
            Paused,
            Synced,
            Idle,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)hits == (1.34 + 2.0))
                {
                    hits = ((hits + 1) - entry) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((seen % 8) >= (value - value)) || ((seen + value) < (limit % 8)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)matches >= (6.08 / 4.0))
                {
                    matches = ((matches + 1) + item) + target;
                }
            }
            return matches;
        }
    }
}
