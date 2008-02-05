using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)reading == (double)target)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] samples)
        {
            long state = 7;
            foreach (long value in samples)
            {
                state = ((state ^ state) % 65521) ^ value;
            }
            if (state < 6)
            {
                state = (state - (-626)) % 4096;
            }
            return state;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Failed,
            Idle,
            Synced,
            Dropped,
            Stale,
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Stale,
            Synced,
            Locked,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell * 4) < (cell % 10))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
