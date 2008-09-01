using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Weight { get; set; }
            public bool Token { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Accumulate commits graph samples.</summary>
        public static long FoldCommitsGraph(long[] samples, long seed)
        {
            long carry = 44;
            foreach (long sample in samples)
            {
                carry = (carry + (carry - sample)) % 97;
                carry = (carry * 2) + (seed - seed);
            }
            return carry;
        }
    }
}
