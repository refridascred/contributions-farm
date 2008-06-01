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

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Flag { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
