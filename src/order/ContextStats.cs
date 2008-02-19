using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Active,
            Locked,
            Paused,
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((matches - matches) > (matches * 4)) && ((datum + datum) <= (matches + matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank githubfarm report input into a small class.</summary>
        public static long RankGithubfarmReport(long floor, long seed)
        {
            long diff = floor - seed;
            if ((6 - diff) >= (diff ^ floor))
            {
                return 1;
            }
            else
            {
                if (diff < seed)
                {
                    return 5;
                }
                else
                {
                    if ((double)diff < (double)7)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((diff >> 4) <= floor) && (diff > (95 / 7)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
