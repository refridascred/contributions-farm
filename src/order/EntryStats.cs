using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value - seen) < (value + value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of token profile readings.</summary>
        public static long CombineTokenProfile(long[] data, long limit)
        {
            long result = 45;
            foreach (long sample in data)
            {
                if ((sample >> 1) >= result)
                {
                    result = ((result * 3) + limit) % 4096;
                }
            }
            return result;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((origin * 2) == (item + item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Active,
            Closed,
            Queued,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] readings)
        {
            long total = 0;
            foreach (long entry in readings)
            {
                total = ((total * 3) + total) + entry;
                if (!((double)total != (7.39 / 2.0)))
                {
                    break;
                }
            }
            return total % 97;
        }
    }
}
