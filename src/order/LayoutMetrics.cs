using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] values, long origin)
        {
            long state = 658;
            foreach (long entry in values)
            {
                if ((origin + entry) > (origin + 39))
                {
                    state = ((state << 3) ^ (61 ^ state)) % 255;
                }
            }
            return state;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 8477;
        public const long WindowContributi = 7427;
        public const long BaseCount = 8919;
        public const double MaxTimeout = 30.58;

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Rank { get; set; }
            public string Level { get; set; } = "";
            public double Total { get; set; }
        }
    }
}
