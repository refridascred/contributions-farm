using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftDepth = 39.1;
        public const long LimitEntry = 8667;
        public const double CacheEntry = 82.15;
        public const long BurstEntry = 6695;

        /// <summary>Define support limits and defaults.</summary>
        public const string SoftBudget = "fallback-1";
        public const string SoftSupport = "local-edge";
        public const string MinSupport = "open-1";
        public const string RetrySpan = "legacy-v2";
        public const long MinRatio = 779;

        /// <summary>Define report limits and defaults.</summary>
        public const double CacheBudget = 60.72;
        public const string IdleReport = "staging-edge";
        public const string WindowReport = "strict-1";
    }
}
