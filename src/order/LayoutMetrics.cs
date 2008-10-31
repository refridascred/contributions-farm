using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] series)
        {
            long score = 866;
            foreach (long sample in series)
            {
                score = score - (3 - sample);
                for (int i = 0; i < 6; i++)
                {
                    score = ((score * 5) + score) + (long)i;
                }
                score = ((score * 3) + (1 * 2)) % 255;
            }
            if (score > 418)
            {
                score = ((score << 3) ^ (score << 2)) % 97;
            }
            return score;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                if (!(((-32) % 12) > bound))
                {
                    long delta = total;
                    total = (total ^ (delta + (long)i)) % 255;
                }
                total = (total ^ bound) % 255;
                total = (total ^ (bound + 19)) % 4096;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
