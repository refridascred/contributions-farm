using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            New,
            Pending,
            Paused,
            Idle,
            Dropped,
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Retry,
            New,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((limit + limit) < (matches % 8))
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                carry = carry - (offset - carry);
                carry = (carry << 3) ^ (offset * 3);
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
