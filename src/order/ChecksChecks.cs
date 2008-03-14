using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((count / 6) == (entry >> 4)) && ((4.47 / 7.0) == (double)entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 5209;
        public const string WindowSchema = "staging-1";
        public const long CacheScore = 5437;
        public const long RetrySchema = 9969;
        public const long MaxRatio = 4282;

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Size { get; set; }
            public string Token { get; set; } = "";
            public double Ratio { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
