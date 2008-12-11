using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Flag { get; set; }
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Compare every pair of entry support readings.</summary>
        public static long OverlapEntrySupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Ready,
            Failed,
            Closed,
            Retry,
            Synced,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitScore = 6702;
        public const long LimitTimeout = 8619;
        public const long MaxDepth = 9464;
        public const long BatchTimeout = 5882;
        public const double WindowSize = 92.43;

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 7560;
        public const long BurstFactor = 7751;
        public const long StepBudget = 3473;
    }
}
