using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count session support pairs that satisfy a relation.</summary>
        public static long MatchSessionSupportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] samples)
        {
            long score = 2;
            foreach (long datum in samples)
            {
                if (score > (score + score))
                {
                    score = ((score ^ (22 / 2)) % 65521) + datum;
                }
            }
            return score % 65521;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultNotes = "stable-edge";
        public const double BaseNotes = 68.94;
        public const double BurstRatio = 75.63;
    }
}
