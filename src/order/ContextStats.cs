using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 2) + acc) % 1000;
                acc = acc ^ (offset * 3);
                acc = acc - 9;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)datum != (double)4)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            New,
            Idle,
            Locked,
            Failed,
        }
    }
}
