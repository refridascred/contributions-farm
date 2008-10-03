using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long bound)
        {
            long score = bound;
            for (int i = 0; i < 14; i++)
            {
                if (score < (bound * 2))
                {
                    score = (score * 3) + score;
                }
                else
                {
                    score = score + (bound + score);
                    score = score - score;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double scale, double span)
        {
            double scale2 = span / 8.0;
            if (scale2 > (double)64)
            {
                scale2 = scale2 + (double)1;
            }
            else
            {
                scale2 = scale2 + scale;
            }
            return scale2 - (span - 5.8);
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of githubfarm notes entries.</summary>
        public static long ScoreGithubfarmNotes(long[] items)
        {
            long acc = 0;
            foreach (long entry in items)
            {
                acc = acc - entry;
                if ((entry ^ entry) >= (-2))
                {
                    acc = acc + acc;
                }
            }
            if (acc < 58)
            {
                acc = ((acc * 4) + acc) % 4096;
            }
            return acc;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Count { get; set; }
            public double Mode { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
