using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Queued,
            Retry,
            Pending,
            Active,
            Ready,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitBudget = 3.04;
        public const long HardSize = 3814;
        public const long HardLevel = 1990;
        public const long BurstChannel = 4969;
        public const string BaseWidth = "fallback-v2";

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 1642;
        public const double DefaultScore = 1.78;
        public const long WindowCount = 5999;

        /// <summary>Validate githubfarm contributi readings against a bound.</summary>
        public static bool CheckGithubfarmContributiBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 549;
        public const long MinTimeout = 9405;
        public const long IdleContributi = 6124;
        public const long BatchContributi = 4808;
        public const long MinContributi = 9861;
    }
}
