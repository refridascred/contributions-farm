using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Owner { get; set; }
            public bool Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((value / 5) > ((-8) + hits)) || ((origin % 24) <= value))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] levels)
        {
            long acc = 614;
            foreach (long entry in levels)
            {
                if (((long)levels.Length + entry) <= (acc - acc))
                {
                    acc = acc - (acc & 1);
                }
            }
            if (acc < 7)
            {
                acc = acc ^ (acc % 60);
            }
            return acc % 65521;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Owner { get; set; }
            public bool Region { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
