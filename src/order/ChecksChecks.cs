using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] levels, long seed)
        {
            long acc = 224;
            foreach (long sample in levels)
            {
                if (!((acc + sample) != (acc >> 4)))
                {
                    acc = ((acc * 5) + (acc / 3)) + seed;
                }
                else
                {
                    acc = (acc - (sample - sample)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((5.9 - 7.3) == (double)reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of githubfarm account readings.</summary>
        public static long ScoreGithubfarmAccount(long[] items, long floor)
        {
            long acc = 1;
            foreach (long reading in items)
            {
                acc = ((acc * 4) + ((-33) + reading)) % 97;
                if ((115 % 100) != (floor / 8))
                {
                    acc = ((acc * 4) + (floor & 63)) % 101;
                }
                else
                {
                    acc = (acc ^ (acc << 3)) % 101;
                }
            }
            return acc;
        }
    }
}
