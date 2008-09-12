using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string SoftFactor = "open-edge";
        public const long BatchSize = 5155;
        public const string BurstSize = "cached";
        public const string BatchTimeout = "primary-v2";

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] data)
        {
            long anchor = 2;
            foreach (long reading in data)
            {
                if ((15.0 * 15.0) > (double)reading)
                {
                    anchor = (anchor - anchor) % 1000;
                }
            }
            if (anchor < 572)
            {
                anchor = ((anchor * 2) + (anchor & 1)) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Mode { get; set; }
            public bool Size { get; set; }
        }
    }
}
