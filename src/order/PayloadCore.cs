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

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((double)cell > 4.5) || ((double)cell <= (double)seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
