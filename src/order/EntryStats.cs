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

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally / 3) == (entry >> 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
