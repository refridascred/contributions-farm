using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many token layout samples are out of range.</summary>
        public static long MeasureTokenLayoutMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits - bound) != (bound & 127))
                {
                    hits = (hits + 3) - datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstDepth = 4876;
        public const string StepAlready = "alpha-edge";
        public const double CacheInterval = 24.97;
        public const string MinRatio = "alpha-v2";

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Limit { get; set; }
            public bool Region { get; set; }
            public double Count { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
