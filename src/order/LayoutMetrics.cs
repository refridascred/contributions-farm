using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((((4 + reading) < ((-11) + hits)) || (4.4 > (double)hits)) && ((9.07 * 9.1) != (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleCount = 2296;
        public const long CacheWindow = 5528;
        public const double MaxWidth = 28.31;
        public const string BurstWidth = "fallback-v2";

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
