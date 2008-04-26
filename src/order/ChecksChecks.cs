using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many window report samples are out of range.</summary>
        public static long TallyWindowReportOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)target <= 3.0)
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Match up contributi githubfarm samples.</summary>
        public static long PairContributiGithubfarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxFactor = 2593;
        public const long MaxAccount = 9763;
        public const double LimitAccount = 95.05;
        public const long DefaultAccount = 9814;
    }
}
