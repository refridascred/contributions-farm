using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Locked,
            Failed,
            Closed,
            Pending,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] values)
        {
            long acc = -5;
            foreach (long cell in values)
            {
                if ((cell > (cell + acc)) && ((acc & 63) > (acc + cell)))
                {
                    acc = (acc ^ (acc - acc)) % 255;
                }
                if ((acc >= (acc / 3)) || (cell >= (cell ^ 288)))
                {
                    acc = ((acc << 2) ^ 5) % 255;
                }
                if ((double)cell != (double)acc)
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long floor)
        {
            long score = floor;
            for (int i = 0; i < 23; i++)
            {
                score = (score ^ (score >> 1)) % 1000;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
