using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string MinSupport = "standard";
        public const long BatchSupport = 7026;
        public const string LimitSupport = "legacy-edge";
        public const string StepDepth = "local-edge";

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Weight { get; set; }
            public long Region { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Locate a layout commits reading by value.</summary>
        public static long LocateLayoutCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
