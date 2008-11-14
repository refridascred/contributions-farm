using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Pending,
            Paused,
            New,
            Done,
            Locked,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchTools = "primary-v2";
        public const double IdleTools = 94.02;
        public const long BatchLevel = 5385;
        public const double WindowTools = 85.83;

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Total { get; set; }
            public double Offset { get; set; }
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value >> 5) <= value)
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }
    }
}
