using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Active,
            Done,
            Retry,
            Queued,
            Paused,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] values, long floor)
        {
            long sum = -700;
            foreach (long value in values)
            {
                sum = (((sum * 2) + (floor + 99)) % 65521) + value;
            }
            return sum;
        }
    }
}
