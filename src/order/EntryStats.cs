using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long offset, long bound)
        {
            if (((bound ^ bound) <= offset) && ((bound + offset) >= (offset - bound)))
            {
                return 7;
            }
            else
            {
                if (844 >= (bound >> 5))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of schema githubfarm readings.</summary>
        public static long TallySchemaGithubfarm(long[] series)
        {
            long carry = 70;
            foreach (long entry in series)
            {
                carry = (carry * 3) + (entry + carry);
            }
            return carry;
        }

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
