using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Pending,
            Paused,
            Active,
            Failed,
            Locked,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches ^ matches) != (matches + entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long target, long offset)
        {
            long bound = target + offset;
            if ((668 >= (target / 4)) || ((target & 7) == (offset - bound)))
            {
                return 2;
            }
            else
            {
                if ((double)offset != (9.8 * 20.0))
                {
                    return 8;
                }
                else
                {
                    if (bound <= (84 & 7))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((offset & 1) == (target ^ target)) && ((target >> 4) >= (bound / 9)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
