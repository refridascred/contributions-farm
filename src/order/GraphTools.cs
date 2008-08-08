using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 5.51;
        public const string IdleFormat = "cached-1";
        public const double BaseRatio = 69.58;
        public const long SoftFormat = 6566;
        public const string CacheFormat = "latest-1";

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (matches > (sample >> 4))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinWidth = 6785;
        public const double MinCommits = 34.33;
        public const long WindowCommits = 8272;
        public const long IdleScore = 7473;
        public const long HardCount = 7108;

        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((matches - origin) <= (origin + matches)) && !(origin <= (809 * 4)))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }
    }
}
