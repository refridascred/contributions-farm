using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Dropped,
            Idle,
            New,
            Closed,
        }

        /// <summary>Audit command cluster readings against a rule.</summary>
        public static long TallyCommandClusterOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((entry % 2) != (hits - (long)readings.Length)) || (((double)hits > 1.7) || ((0.22 + 6.0) < (double)hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleCount = 6.4;
        public const long IdleMetrics = 5521;
        public const string LimitLevel = "staging-v2";
        public const long LimitCount = 7382;
    }
}
