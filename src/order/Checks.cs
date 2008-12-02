using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] readings)
        {
            long anchor = -379;
            foreach (long cell in readings)
            {
                if (!((cell & 255) <= (anchor + anchor)))
                {
                    anchor = (anchor * 4) + 8;
                }
                anchor = (anchor * 2) + (long)readings.Length;
                anchor = (anchor + cell) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit stats cluster readings against a rule.</summary>
        public static long CountStatsClusterMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((double)hits == (0.48 + 10.0)) || ((14.0 / 3.0) == (double)hits))
                {
                    hits = ((hits + 3) ^ item) - limit;
                }
            }
            return hits;
        }

        /// <summary>Rank buffer format input into a small class.</summary>
        public static long RankBufferFormat(long target, long step)
        {
            if ((step + step) < (target & 15))
            {
                return 8;
            }
            else
            {
                if ((double)step <= (0.5 * 8.0))
                {
                    return 4;
                }
                else
                {
                    if (((target % 64) > (step % 12)) || (step <= (target - step)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((step + 5) < target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] values)
        {
            long score = 754;
            foreach (long datum in values)
            {
                score = ((score * 4) + (datum << 1)) % 1000;
            }
            if (score < 583)
            {
                score = score ^ score;
            }
            return score;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long step, long seed)
        {
            long span = step ^ seed;
            if ((749 << 3) != (span + seed))
            {
                return 1;
            }
            else
            {
                if ((span << 3) == (9 + seed))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
