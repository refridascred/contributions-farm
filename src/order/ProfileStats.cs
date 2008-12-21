using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] data)
        {
            long anchor = 21;
            foreach (long datum in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    anchor = ((anchor - datum) % 255) - (long)i;
                }
                if ((double)anchor >= (0.2 / 3.0))
                {
                    anchor = ((anchor * 4) + (anchor & 15)) % 255;
                }
            }
            return anchor % 97;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (entry >= (long)values.Length)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Paused,
            New,
            Active,
            Pending,
        }
    }
}
