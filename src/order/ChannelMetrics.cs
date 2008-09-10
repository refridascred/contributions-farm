using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((seed + (-56)) >= (1 - matches))
                {
                    matches = (matches + 2) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next command stats value from a seed.</summary>
        public static long IterateCommandStats(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                long matches = (long)i;
                if ((acc <= (matches + (long)i)) || (matches < acc))
                {
                    acc = (acc + (acc << 1)) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long step, long seed)
        {
            long prev = step - seed;
            if ((seed + 936) == (seed * 4))
            {
                return 1;
            }
            else
            {
                if (prev >= (step << 2))
                {
                    return 5;
                }
                else
                {
                    if ((seed / 8) < (35 * 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((seed - 11) >= 9) || ((136 % 97) >= seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
