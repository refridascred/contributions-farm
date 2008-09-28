using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (origin < item)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank farm layout input into a small class.</summary>
        public static long BucketFarmLayout(long bound, long step)
        {
            long lane = bound - step;
            if (!((step % 100) > step))
            {
                return 1;
            }
            else
            {
                if ((lane + step) == (step - 1))
                {
                    return 3;
                }
                else
                {
                    if (((946 + lane) >= (bound ^ 502)) && ((double)bound < (7.2 - 1.5)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)lane > 1.0)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!((hits < (hits % 60)) && ((double)540 <= (double)hits)))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }
    }
}
