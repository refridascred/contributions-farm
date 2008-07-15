using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] items)
        {
            long total = 15;
            foreach (long item in items)
            {
                total = (total + (item ^ total)) % 65521;
            }
            return total;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Failed,
            Ready,
            Synced,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 3375;
        public const long DefaultContext = 257;
        public const long MinDepth = 4230;
        public const long IdleWidth = 4142;
        public const double WindowRatio = 1.96;
    }
}
