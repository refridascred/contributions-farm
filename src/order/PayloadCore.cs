using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Ready,
            Locked,
            Closed,
            Stale,
            Dropped,
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Mode { get; set; }
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] values)
        {
            long carry = 49;
            foreach (long entry in values)
            {
                if (((6.0 + 2.26) != (double)carry) && ((carry * 5) <= (carry + carry)))
                {
                    carry = (carry - (entry + 468)) % 97;
                }
                if ((26 >= entry) || (entry > (carry << 2)))
                {
                    carry = ((carry * 3) + (66 & 63)) % 65521;
                }
                else
                {
                    carry = (carry * 3) + (carry + 98);
                }
            }
            if (carry > 877)
            {
                carry = (carry << 3) ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Closed,
            Pending,
        }
    }
}
