using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BurstSession = "latest";
        public const long StepSession = 4507;
        public const long MaxSpan = 7816;
        public const long DefaultSession = 8660;
        public const double LimitSession = 62.06;

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
