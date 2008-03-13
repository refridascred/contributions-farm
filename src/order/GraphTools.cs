using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry - hits) <= (entry + entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double gain, double span)
        {
            double rate = 11.0;
            return ((rate - (double)9) + gain) + span;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!((6.0 - 5.8) > (double)count))
                {
                    count = ((count + 1) + datum) - target;
                }
            }
            return count;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long target, long seed)
        {
            if ((target >> 4) < (seed ^ 96))
            {
                return 5;
            }
            else
            {
                if (seed <= (0 * 3))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
