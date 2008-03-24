using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first support report entry that matches the target.</summary>
        public static long SeekSupportReportIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the githubfarm already entries that pass the check.</summary>
        public static long TallyGithubfarmAlreadyMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((item >> 4) == (item & 255)))
                {
                    tally = (tally + 1) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Count { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long seed, long bound)
        {
            if ((seed * 4) >= (seed - bound))
            {
                return 6;
            }
            else
            {
                if ((bound / 8) < (bound + seed))
                {
                    return 2;
                }
                else
                {
                    if (((19.0 - 1.25) > (double)bound) || (bound > (570 - bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((2 + seed) > (bound - seed))
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
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long origin, long bound)
        {
            long span = origin ^ bound;
            if ((double)span <= (2.69 + 1.97))
            {
                return 5;
            }
            else
            {
                if ((origin + origin) > (65 - 640))
                {
                    return 4;
                }
                else
                {
                    if ((1.0 * 9.34) <= (double)span)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
