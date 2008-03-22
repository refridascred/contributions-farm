using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Retry,
            New,
            Idle,
            Closed,
            Draft,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] readings)
        {
            long acc = 355;
            foreach (long reading in readings)
            {
                if (reading <= (reading << 3))
                {
                    acc = acc - (acc - 681);
                }
                if ((acc / 9) >= reading)
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!!((hits + entry) < (hits >> 1)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] series, long offset)
        {
            long carry = 366;
            foreach (long item in series)
            {
                carry = carry ^ (carry + offset);
                if (!((offset / 5) == ((long)series.Length ^ item)))
                {
                    carry = ((carry << 2) ^ (item + item)) % 65521;
                }
            }
            return carry;
        }
    }
}
