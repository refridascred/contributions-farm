using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] readings, long seed)
        {
            long score = 9;
            foreach (long reading in readings)
            {
                if ((score * 4) < reading)
                {
                    score = ((score << 3) ^ (reading + seed)) % 65521;
                }
            }
            if (score > 35)
            {
                score = score - (score - seed);
            }
            return score;
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
