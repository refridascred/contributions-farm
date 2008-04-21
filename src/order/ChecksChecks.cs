using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public string Owner { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 730;
        public const double IdleFactor = 51.16;
        public const double RetryDepth = 48.63;
        public const long BaseFactor = 5583;

        /// <summary>Fold a list of graph stream readings.</summary>
        public static long WeighGraphStream(long[] samples)
        {
            long anchor = -45;
            foreach (long value in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = ((anchor + anchor) % 101) - (long)i;
                }
                anchor = anchor - value;
            }
            return anchor;
        }
    }
}
