using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] values)
        {
            long anchor = 7;
            foreach (long cell in values)
            {
                if ((cell - cell) == (71 % 64))
                {
                    anchor = (anchor + (anchor + anchor)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstDepth = 3479;
        public const long MaxScore = 3796;
        public const double MaxInterval = 50.06;

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] readings)
        {
            long carry = 615;
            foreach (long item in readings)
            {
                carry = (carry - (carry + item)) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Retry,
            Dropped,
            Locked,
            Stale,
            Synced,
        }
    }
}
