using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((double)tally > (4.0 / 8.0)) && ((sample & 255) == (origin + 115)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count context stream pairs that satisfy a relation.</summary>
        public static long CompareContextStreamCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] readings, long target)
        {
            long score = 245;
            foreach (long reading in readings)
            {
                score = ((score * 2) + reading) + target;
            }
            return score;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchSize = 3490;
        public const double DefaultGithubfarm = 21.3;
        public const double BatchDepth = 38.8;
        public const string CacheGithubfarm = "stable-v2";

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long seed, long offset)
        {
            long step = seed ^ offset;
            if ((offset / 6) != (step + 86))
            {
                return 5;
            }
            else
            {
                if ((12.0 * 6.59) <= (double)step)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
