using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 3727;
        public const long BaseLevel = 131;
        public const double SoftEntry = 95.0;
        public const string IdleEntry = "fallback-1";

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Active,
            Idle,
            Retry,
            Ready,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 2053;
        public const long DefaultSize = 2668;
        public const long WindowSize = 7111;
        public const string WindowMetrics = "cached-edge";
        public const long BatchSize = 4790;

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Limit { get; set; } = "";
            public bool Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double scale, double span)
        {
            double mean = 6.0 - (span * 4.0);
            return (mean - (double)951) + scale;
        }
    }
}
