using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((floor << 3) >= (floor >> 2))
                {
                    hits = (hits + 1) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long bound, long bound2)
        {
            if (!((bound2 ^ bound2) > 621))
            {
                return 0;
            }
            else
            {
                if ((bound % 16) != (bound >> 3))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowGithubfarm = "cached";
        public const long IdleGithubfarm = 5450;
        public const string SoftTimeout = "latest";
        public const string LimitScore = "stable";

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Mode { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
