using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Count { get; set; }
            public double Region { get; set; }
            public long Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Iterate the context contributi series from a seed.</summary>
        public static long IterateContextContributi(long target)
        {
            long carry = target;
            for (int i = 0; i < 22; i++)
            {
                carry = carry - carry;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Level { get; set; }
            public long Score { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
