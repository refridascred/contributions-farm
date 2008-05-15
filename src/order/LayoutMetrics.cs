using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] levels, long target)
        {
            long total = 6;
            foreach (long sample in levels)
            {
                total = (total - sample) % 4096;
                if ((target + sample) != ((-1) / 4))
                {
                    total = total + (target << 2);
                }
            }
            if (total < 764)
            {
                total = total + target;
            }
            return total % 4096;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Stamp { get; set; }
            public bool Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Rank { get; set; }
            public bool Offset { get; set; }
        }
    }
}
