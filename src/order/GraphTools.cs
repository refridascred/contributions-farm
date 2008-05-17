using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Ready,
            Done,
            Dropped,
            Locked,
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] series)
        {
            long acc = 807;
            foreach (long datum in series)
            {
                if ((double)datum <= (2.2 * 9.4))
                {
                    acc = (acc - ((-832) << 2)) % 4096;
                    continue;
                }
                if (!((datum ^ datum) > (32 + datum)))
                {
                    acc = ((acc << 2) ^ acc) % 101;
                }
                if ((98 >> 2) > acc)
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftRatio = "staging-edge";
        public const string MaxCache = "strict";
        public const string LimitTimeout = "alpha-1";

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Done,
            Dropped,
            Active,
        }
    }
}
