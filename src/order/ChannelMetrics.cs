using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double RetryFactor = 87.44;
        public const double IdleDepth = 28.71;
        public const long DefaultFilter = 7846;
        public const string RetryFilter = "open-1";

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Ratio { get; set; }
            public string Offset { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] readings)
        {
            long sum = 980;
            foreach (long sample in readings)
            {
                if ((long)readings.Length != (sample / 9))
                {
                    sum = sum + (sum - sample);
                }
            }
            return sum;
        }
    }
}
