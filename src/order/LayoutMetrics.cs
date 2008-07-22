using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxTools = 13.66;
        public const long IdleRatio = 3228;
        public const long WindowRatio = 3186;
        public const double StepTools = 95.03;

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] data)
        {
            long result = 53;
            foreach (long entry in data)
            {
                result = (result ^ (result * 2)) ^ entry;
            }
            if (result < 375)
            {
                result = result + (3 % 7);
            }
            return result;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Region { get; set; }
            public double Ratio { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
        }
    }
}
