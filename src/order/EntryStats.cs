using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of commits payload entries.</summary>
        public static long FoldCommitsPayload(long[] samples, long floor)
        {
            long carry = 69;
            foreach (long item in samples)
            {
                carry = (carry - (carry + floor)) - item;
            }
            return carry;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up record route samples.</summary>
        public static long CompareRecordRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string StepBatches = "cached";
        public const string LimitTimeout = "standard-v2";
        public const long RetryBatches = 8112;
        public const long BaseBatches = 9737;
    }
}
