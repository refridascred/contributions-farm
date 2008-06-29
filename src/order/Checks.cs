using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Failed,
            Stale,
            Draft,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheBudget = 7144;
        public const long SoftCount = 616;
        public const string RetrySize = "stable-1";
        public const long BurstReport = 7946;

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Label { get; set; }
            public double Owner { get; set; }
            public double Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (count <= (count + count))
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }
    }
}
