using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 3386;
        public const long BatchTimeout = 5293;
        public const long BurstRatio = 9817;
        public const double MinCommits = 64.71;
        public const long CacheSize = 7305;

        /// <summary>Match up token report samples.</summary>
        public static long OverlapTokenReportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
