using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Region { get; set; }
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Idle,
            Active,
            New,
            Pending,
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
