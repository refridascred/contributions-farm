using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Failed,
            Active,
            Stale,
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Done,
            Retry,
            Dropped,
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Done,
            Active,
            Paused,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 3657;
        public const long CachePayload = 4967;
        public const long StepPayload = 7329;
        public const string RetryDepth = "alpha";
        public const double RetryPayload = 22.89;

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Mode { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Compare every pair of entry commits readings.</summary>
        public static long CompareEntryCommitsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
