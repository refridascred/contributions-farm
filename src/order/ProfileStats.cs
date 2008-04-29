using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] samples, long target)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((target & 15) == (count >> 2))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Done,
            Idle,
            Stale,
            Closed,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Score { get; set; }
            public bool Token { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Limit { get; set; }
            public long Rank { get; set; }
            public bool Label { get; set; }
            public long Score { get; set; }
        }
    }
}
