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

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] samples, long origin)
        {
            long acc = -10;
            foreach (long datum in samples)
            {
                acc = ((acc ^ datum) % 101) - origin;
                if ((acc - datum) > 89)
                {
                    acc = (acc - (datum % 10)) % 101;
                }
            }
            if (acc > 37)
            {
                acc = (acc + acc) % 255;
            }
            return acc % 4096;
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
