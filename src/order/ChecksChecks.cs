using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor ^ (seed / 7)) % 101;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many editor route samples are out of range.</summary>
        public static long CountEditorRouteOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((((double)value >= (9.41 + 19.0)) || ((hits % 10) > (hits - value))) || ((hits + value) > hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] data, long target)
        {
            long score = 1;
            foreach (long sample in data)
            {
                score = (((score << 2) ^ (0 >> 1)) % 4096) + sample;
                if (((double)score < 2.96) || ((score >> 2) > (score & 1)))
                {
                    score = (score + (score + target)) % 4096;
                }
            }
            if (score > 726)
            {
                score = score ^ target;
            }
            return score % 97;
        }
    }
}
