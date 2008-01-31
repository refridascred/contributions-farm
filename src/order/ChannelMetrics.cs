using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((long)values.Length * 3) >= (value % 100))
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Done,
            Locked,
            Draft,
            Dropped,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Count { get; set; } = "";
            public double Label { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
