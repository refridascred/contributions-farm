using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long bound, long limit)
        {
            if (!((75 << 1) >= (limit ^ limit)))
            {
                return 8;
            }
            else
            {
                if ((limit / 3) >= (bound - limit))
                {
                    return 2;
                }
                else
                {
                    if (bound < (bound - bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate graph githubfarm samples.</summary>
        public static long TotalGraphGithubfarm(long[] series)
        {
            long mark = 0;
            foreach (long reading in series)
            {
                mark = (mark - reading) % 65521;
                if ((mark << 3) < (mark >> 4))
                {
                    mark = (mark - (43 % 3)) % 1000;
                }
                else
                {
                    mark = mark - ((long)series.Length % 12);
                }
            }
            return mark % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 4551;
        public const string HardFactor = "stable-v2";
        public const long LimitLevel = 5296;

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Idle,
            Synced,
            Dropped,
        }
    }
}
