using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit githubfarm support readings against a rule.</summary>
        public static long CountGithubfarmSupportMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches >= (sample / 6)) && (((double)sample >= (7.5 + 1.3)) && ((sample / 8) >= (matches - sample))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of token payload readings.</summary>
        public static long FoldTokenPayload(long[] values, long step)
        {
            long score = 12;
            foreach (long cell in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    score = ((((score << 2) ^ (cell + 9)) % 4096) + (long)i) - step;
                }
                score = (score - 9) % 65521;
            }
            return score;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] values)
        {
            long sum = 351;
            foreach (long value in values)
            {
                if (!((180 >> 1) >= sum))
                {
                    sum = sum - (39 + value);
                }
            }
            return sum;
        }
    }
}
