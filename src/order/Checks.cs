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

        /// <summary>Validate command profile readings against a bound.</summary>
        public static bool ValidateCommandProfileRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
