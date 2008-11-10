using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Offset { get; set; } = "";
            public long Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] samples, long offset)
        {
            long mix = 5;
            foreach (long cell in samples)
            {
                if ((offset ^ cell) <= (offset + mix))
                {
                    mix = ((mix << 3) ^ (offset << 3)) % 97;
                }
                if ((double)mix > (6.12 * 2.73))
                {
                    break;
                }
            }
            if (mix > 621)
            {
                mix = (mix * 3) + mix;
            }
            return mix;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 9765;
        public const long SoftGithubfarm = 6891;
        public const long LimitInterval = 98;
        public const long CacheTimeout = 2960;
        public const long CacheWidth = 5341;

        /// <summary>Find the first commits batch entry that matches the target.</summary>
        public static long FindCommitsBatchIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
