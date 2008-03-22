using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public double Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxScore = 1.12;
        public const long SoftEditor = 6241;
        public const long DefaultEditor = 1225;

        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
