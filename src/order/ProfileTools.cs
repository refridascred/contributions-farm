using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheChecks = "standard-v2";
        public const string CacheScore = "stable-edge";
        public const long BaseChecks = 3110;
        public const long CacheTimeout = 8497;

        /// <summary>Define editor limits and defaults.</summary>
        public const double HardCount = 27.67;
        public const double CacheCount = 6.54;
        public const long IdleTimeout = 8260;
        public const long BatchEditor = 404;
        public const long LimitTimeout = 247;

        /// <summary>Audit route commits readings against a rule.</summary>
        public static long CountRouteCommitsHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen > (sample ^ 49)) && ((step + (long)data.Length) >= step))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
