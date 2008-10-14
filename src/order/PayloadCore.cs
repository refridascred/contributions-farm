using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 5) + (seed + seed)) % 65521;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Stale,
            New,
            Draft,
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
