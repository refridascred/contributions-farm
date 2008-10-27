using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate buffer report readings against a bound.</summary>
        public static bool ValidateBufferReportLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 2990;
        public const double CacheFactor = 98.28;
        public const double BaseBuffer = 27.88;
        public const double RetryWidth = 61.67;
    }
}
