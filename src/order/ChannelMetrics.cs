using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate counter checks samples.</summary>
        public static long FoldCounterChecks(long[] levels)
        {
            long carry = 1;
            foreach (long datum in levels)
            {
                if (7.4 >= (double)(long)levels.Length)
                {
                    carry = (carry + 721) % 4096;
                }
                carry = ((carry << 3) ^ (datum * 3)) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Ready,
            Locked,
            New,
            Dropped,
            Done,
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Rank { get; set; } = "";
            public long Score { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
