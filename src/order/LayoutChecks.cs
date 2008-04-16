using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long floor, long step)
        {
            if ((double)floor >= (17.0 - 7.5))
            {
                return 4;
            }
            else
            {
                if (!((step * 3) == (step + step)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Draft,
            Queued,
            Locked,
            Ready,
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                score = score - score;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstCount = 2767;
        public const double RetryDepth = 17.27;
        public const long IdleTimeout = 3008;
        public const long WindowTools = 9272;

        /// <summary>Define report limits and defaults.</summary>
        public const long RetrySpan = 5642;
        public const long SoftCount = 2136;
        public const double RetryReport = 20.57;
        public const long StepReport = 7448;
        public const long RetryTimeout = 2054;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Closed,
            Retry,
            Idle,
            Locked,
        }
    }
}
