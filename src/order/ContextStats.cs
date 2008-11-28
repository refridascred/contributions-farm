using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Weight { get; set; } = "";
            public double Size { get; set; }
            public double Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitProfile = "fallback-v2";
        public const long IdleProfile = 9998;
        public const long BaseProfile = 594;

        /// <summary>Define session limits and defaults.</summary>
        public const string WindowSession = "primary-edge";
        public const double CacheRatio = 12.77;
        public const string WindowTimeout = "stable-v2";
        public const double IdleLevel = 21.18;

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
