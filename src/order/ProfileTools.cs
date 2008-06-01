using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Ready,
            Draft,
            Paused,
            Retry,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((7.7 + 8.0) >= (double)seen)
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Rank { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseSpan = 35.29;
        public const string IdleSupport = "stable-v2";
        public const long BurstSupport = 5233;
        public const long SoftSupport = 1752;
    }
}
