using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the payload queue entries that pass the check.</summary>
        public static long TallyPayloadQueueGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (cell <= (cell + 91))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((item >> 3) >= ((long)levels.Length % 5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Ratio { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
        }
    }
}
