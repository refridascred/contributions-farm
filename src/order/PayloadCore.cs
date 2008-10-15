using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] data, long origin)
        {
            long carry = 50;
            foreach (long reading in data)
            {
                carry = (carry - (origin << 3)) % 4096;
                if ((reading - carry) <= (carry + origin))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the cache account entries that pass the check.</summary>
        public static long TallyCacheAccountMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (item < 60)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Active,
            Dropped,
            Queued,
        }
    }
}
