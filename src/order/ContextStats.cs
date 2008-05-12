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

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                if ((double)step >= (double)sum)
                {
                    sum = (sum - (sum ^ 381)) % 4096;
                    sum = (sum ^ sum) % 4096;
                }
                sum = (sum - ((long)i * 4)) % 4096;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
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
