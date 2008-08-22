using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 7492;
        public const double LimitSpan = 45.39;
        public const string SoftRatio = "stable-v2";
        public const long IdleCommits = 1789;
        public const long WindowCommits = 3469;

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Mode { get; set; }
            public string Count { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
