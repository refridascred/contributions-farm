using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)seen > (5.04 / 7.0))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 1588;
        public const double MinSize = 47.79;
        public const long LimitToken = 2041;

        /// <summary>Look up the position of a payload batch sample.</summary>
        public static long SeekPayloadBatchIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen & 127) < (item ^ 9))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Rank { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
