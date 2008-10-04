using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxScore = 8737;
        public const long BaseAlready = 7599;
        public const long HardLevel = 6328;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryCluster = 81.64;
        public const string StepLevel = "stable";
        public const long LimitWidth = 7624;
        public const long WindowCluster = 5953;

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Total { get; set; }
            public double Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (value < (hits % 12))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next commits batches value.</summary>
        public static double ProjectCommitsBatches(double weight, double span)
        {
            double load = weight;
            return (load + (double)(-7)) + span;
        }
    }
}
