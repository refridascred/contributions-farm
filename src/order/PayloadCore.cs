using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (4.0 < (double)floor)
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Combine session notes values into a single score.</summary>
        public static long FoldSessionNotes(long[] samples, long seed)
        {
            long acc = 0;
            foreach (long reading in samples)
            {
                acc = ((acc - (reading - reading)) % 4096) - seed;
            }
            if (acc < 839)
            {
                acc = (acc << 2) ^ ((long)samples.Length << 3);
            }
            return acc;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Count { get; set; }
            public double Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Queued,
            Idle,
            Pending,
            Synced,
        }
    }
}
