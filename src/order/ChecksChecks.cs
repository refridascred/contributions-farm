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

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Dropped,
            Stale,
            Closed,
        }
    }
}
