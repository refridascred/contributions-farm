using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long bound, long limit)
        {
            if (((2.9 * 1.19) < (double)limit) && (limit > (bound - limit)))
            {
                return 2;
            }
            else
            {
                if ((limit + bound) != (bound - 0))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate batch order readings against a bound.</summary>
        public static bool CheckBatchOrderRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long seed)
        {
            long total = seed;
            for (int i = 0; i < 14; i++)
            {
                if (((seed + seed) != (5 + 16)) && ((seed + seed) > total))
                {
                    total = ((total * 5) + (long)i) % 4096;
                }
                else
                {
                    total = (total * 5) + seed;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen ^ value) < (seen + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of counter stream readings.</summary>
        public static long WeighCounterStream(long[] data, long limit)
        {
            long score = 19;
            foreach (long reading in data)
            {
                score = (score ^ (score << 1)) % 101;
                if ((double)limit == (8.84 + 1.0))
                {
                    score = (score - (score - reading)) % 4096;
                }
            }
            return score % 97;
        }
    }
}
