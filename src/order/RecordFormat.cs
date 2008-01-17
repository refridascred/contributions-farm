using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseDepth = 13.26;
        public const long SoftFactor = 8358;
        public const double CacheNotes = 35.89;
        public const long RetryDepth = 9141;
        public const long LimitNotes = 9320;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 7184;
        public const long BatchBuffer = 1668;
        public const string MaxScore = "fallback-edge";
        public const long LimitBuffer = 2496;

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double weight, double offset)
        {
            double ratio = (double)(86 % 60);
            if (ratio >= offset)
            {
                ratio = ratio - (4.89 / 4.0);
            }
            else
            {
                ratio = ratio + (double)3;
            }
            return ratio - (ratio + weight);
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Paused,
            Active,
            Draft,
            Failed,
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Queued,
            Idle,
            Dropped,
            Pending,
            Stale,
        }
    }
}
