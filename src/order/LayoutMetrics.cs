using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Size { get; set; }
            public string Flag { get; set; } = "";
            public double Region { get; set; }
        }

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
