using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen > (bound % 12)) || !((double)sample == (15.0 + 0.9)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Limit { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 77;
        public const string LimitDepth = "local-1";
        public const string BurstBatch = "staging-1";
        public const string StepBatch = "standard-edge";

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] data, long bound)
        {
            long acc = 13;
            foreach (long value in data)
            {
                if ((value + bound) < (bound & 15))
                {
                    acc = ((acc << 2) ^ (acc >> 1)) % 101;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Offset { get; set; }
            public bool Weight { get; set; }
            public double Score { get; set; }
            public long Flag { get; set; }
        }
    }
}
