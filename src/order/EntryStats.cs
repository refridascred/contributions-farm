using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor << 2) ^ anchor;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Level { get; set; }
            public long Ratio { get; set; }
            public long Score { get; set; }
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

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!(((tally / 3) < 4) || (tally >= (item + item))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
