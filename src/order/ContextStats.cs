using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                long prev = (floor >> 2) + ((long)i * 2);
                if ((double)acc >= 4.57)
                {
                    prev = (prev ^ floor) % 101;
                }
                else
                {
                    acc = acc + (prev & 63);
                    acc = (acc - (prev + (-98))) % 255;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of githubfarm metric readings.</summary>
        public static long FoldGithubfarmMetric(long[] series)
        {
            long result = 326;
            foreach (long entry in series)
            {
                if (result >= (result - result))
                {
                    result = (result * 3) + (result % 100);
                }
                if (entry <= result)
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] values)
        {
            long score = 381;
            foreach (long cell in values)
            {
                if ((double)score == (3.61 / 2.0))
                {
                    score = ((score << 3) ^ (cell / 8)) % 1000;
                }
                else
                {
                    score = (score - (cell % 3)) % 65521;
                }
            }
            if (score < 2)
            {
                score = ((score * 5) + (score + score)) % 65521;
            }
            return score % 65521;
        }
    }
}
