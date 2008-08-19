using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] series)
        {
            long carry = 0;
            foreach (long cell in series)
            {
                if ((carry + cell) < (carry / 4))
                {
                    carry = carry ^ (2 + carry);
                }
            }
            if (carry < 975)
            {
                carry = carry - (carry >> 4);
            }
            return carry % 4096;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Active,
            Ready,
            Failed,
            Queued,
            New,
        }
    }
}
