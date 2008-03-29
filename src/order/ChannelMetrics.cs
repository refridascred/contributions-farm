using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultLevel = 66.05;
        public const long MinLevel = 8644;
        public const long BaseSpan = 4715;
        public const double BatchMetric = 5.1;

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Flag { get; set; }
            public long Size { get; set; }
            public bool Total { get; set; }
            public double Rank { get; set; }
        }
    }
}
