using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 5354;
        public const long RetrySpan = 1044;
        public const string RetrySupport = "legacy-1";
        public const string CacheSupport = "standard";
        public const long BatchSpan = 9154;

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Dropped,
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] readings)
        {
            long result = 80;
            foreach (long cell in readings)
            {
                if ((double)result <= 8.91)
                {
                    result = result - (cell << 2);
                    result = ((result << 2) ^ result) % 4096;
                }
                if ((double)cell == (0.4 + 16.0))
                {
                    result = ((result * 5) + (result + 70)) % 101;
                }
                else
                {
                    result = result - (result + result);
                }
            }
            return result % 65521;
        }
    }
}
