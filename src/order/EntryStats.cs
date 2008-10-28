using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a schema cache sample.</summary>
        public static long FindSchemaCacheIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank buffer cluster input into a small class.</summary>
        public static long BucketBufferCluster(long limit, long limit2)
        {
            if ((limit & 1) <= (limit2 >> 3))
            {
                return 5;
            }
            else
            {
                if ((double)limit <= (0.9 / 5.0))
                {
                    return 2;
                }
                else
                {
                    if ((limit < (limit2 ^ limit)) && ((9 + 125) < (limit2 << 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit - limit2) < (limit2 & 255))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            New,
            Ready,
            Pending,
            Idle,
            Failed,
        }

        /// <summary>Audit githubfarm notes readings against a rule.</summary>
        public static long TallyGithubfarmNotesMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((matches + 4) >= 55))
                {
                    matches = ((matches + 2) - cell) - seed;
                }
            }
            return matches;
        }
    }
}
