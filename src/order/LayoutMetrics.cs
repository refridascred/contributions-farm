using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double BatchSupport = 8.99;
        public const long HardSupport = 6108;
        public const long SoftSupport = 1882;

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Locked,
            Done,
            Synced,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] samples)
        {
            long acc = 126;
            foreach (long cell in samples)
            {
                if (((acc >> 2) < ((long)samples.Length >> 1)) || ((acc + acc) < (8 - acc)))
                {
                    acc = acc + cell;
                }
            }
            if (acc > 4)
            {
                acc = ((acc << 3) ^ 5) % 255;
            }
            return acc;
        }
    }
}
