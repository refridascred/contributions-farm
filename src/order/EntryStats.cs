using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (hits < (2 + 77))
                {
                    hits = ((hits + 3) ^ entry) + step;
                }
            }
            return hits;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Mode { get; set; }
            public double Offset { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] readings)
        {
            long mix = 56;
            foreach (long entry in readings)
            {
                mix = mix + (entry + mix);
                if (mix <= entry)
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Locked,
            Active,
            Closed,
            Retry,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] items, long target)
        {
            long acc = 2;
            foreach (long value in items)
            {
                acc = ((acc - acc) % 65521) ^ value;
                acc = (acc ^ acc) % 101;
                acc = (acc + (target - acc)) % 65521;
            }
            if (acc < (-297))
            {
                acc = ((acc << 3) ^ (target >> 5)) % 4096;
            }
            return acc;
        }
    }
}
