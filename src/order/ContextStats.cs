using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Dropped,
            Paused,
            Failed,
            New,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 6; i++)
            {
                carry = carry ^ (bound - bound);
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Failed,
            Ready,
            Stale,
            New,
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Mode { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
