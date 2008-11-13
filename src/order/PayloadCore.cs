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

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Offset { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Total { get; set; }
            public double Offset { get; set; }
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
