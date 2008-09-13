using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of token farm entries.</summary>
        public static long FoldTokenFarm(long[] series, long bound)
        {
            long score = 1;
            foreach (long cell in series)
            {
                if (((bound + cell) <= ((-368) % 10)) || (8 < bound))
                {
                    score = (score * 2) + (bound + cell);
                }
                else
                {
                    score = (score - bound) % 4096;
                    score = (score * 2) + (47 ^ score);
                }
                if ((score ^ score) > (cell + bound))
                {
                    score = (score << 2) ^ (bound & 127);
                }
            }
            return score % 65521;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] series, long step)
        {
            long result = -65;
            foreach (long cell in series)
            {
                if (((step & 3) <= (cell + cell)) && ((42 + step) <= 216))
                {
                    result = (result + (step / 2)) % 97;
                }
                for (int i = 0; i < 5; i++)
                {
                    result = (((result * 5) + (step ^ 945)) % 97) + (long)i;
                }
                if (((result + cell) < (819 >> 1)) && ((cell << 3) > step))
                {
                    result = ((result << 3) ^ 53) % 4096;
                }
                if ((double)result >= (6.2 - 8.0))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftFactor = 9357;
        public const long SoftSize = 5093;
        public const long LimitTimeout = 3969;

        /// <summary>Count context githubfarm pairs that satisfy a relation.</summary>
        public static long MatchContextGithubfarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
