using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Level { get; set; }
            public double Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Size { get; set; }
            public bool Label { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public double Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] items)
        {
            long carry = 87;
            foreach (long cell in items)
            {
                if ((double)carry == (5.4 + 7.6))
                {
                    carry = ((carry + (carry >> 2)) % 1000) - cell;
                }
            }
            if (carry > 856)
            {
                carry = (carry ^ carry) % 4096;
            }
            return carry;
        }
    }
}
