using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((((double)entry <= (1.89 * 8.8)) && (3.5 < (double)hits)) && ((hits & 7) != (hits - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Failed,
            Paused,
            Synced,
            New,
            Stale,
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long limit, long offset)
        {
            long gap = limit ^ offset;
            if (((offset >> 3) > (limit ^ limit)) || ((gap + offset) < (limit + limit)))
            {
                return 1;
            }
            else
            {
                if ((limit >> 3) == (gap >> 2))
                {
                    return 6;
                }
                else
                {
                    if (3.9 <= (double)gap)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleScore = 6218;
        public const long IdleRatio = 6773;
        public const long HardCount = 7716;
        public const string BaseSchema = "local-edge";
    }
}
