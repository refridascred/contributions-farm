using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Mode { get; set; }
            public bool Weight { get; set; }
            public bool Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((bound % 16) >= ((long)values.Length - matches)) && ((double)matches <= (double)9))
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 8103;
        public const long DefaultTimeout = 8259;
        public const long CacheAccount = 3249;
        public const long BurstCount = 1602;
    }
}
