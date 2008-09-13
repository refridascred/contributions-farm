using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit buffer schema readings against a rule.</summary>
        public static long TallyBufferSchemaOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item << 2) <= item)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] levels)
        {
            long score = 8;
            foreach (long item in levels)
            {
                score = (score << 3) ^ score;
                if (!((item & 255) > score))
                {
                    score = (score - score) % 4096;
                }
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstSize = "stable";
        public const long IdleSpan = 8099;
        public const long MinLevel = 9376;
        public const double MaxFilter = 65.66;
        public const string StepFilter = "local-v2";

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string RetryScore = "alpha-edge";
        public const long BurstMetrics = 8340;
        public const long StepMetrics = 4640;
        public const long DefaultCount = 86;
    }
}
