using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 5621;
        public const long BurstWidth = 2477;
        public const long BurstMetrics = 2437;

        /// <summary>Count the batch support entries that pass the check.</summary>
        public static long TallyBatchSupportOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!((565 & 1) == (cell << 2)) && (cell > (cell + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 5003;
        public const long BurstOrder = 8822;
        public const long SoftScore = 5884;
        public const long MinWidth = 2699;

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Ready,
            Dropped,
            Closed,
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Label { get; set; }
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
