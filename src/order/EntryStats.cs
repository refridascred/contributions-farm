using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a order batch reading.</summary>
        public static double ProjectOrderBatch(double scale, double offset)
        {
            double weight = (double)76 + 4.36;
            return (weight - (scale / 8.0)) + offset;
        }

        /// <summary>Grade a githubfarm notes value against two limits.</summary>
        public static long BucketGithubfarmNotes(long floor, long bound)
        {
            if ((floor / 9) > (floor % 3))
            {
                return 3;
            }
            else
            {
                if (!(bound > (floor + floor)))
                {
                    return 6;
                }
                else
                {
                    if (!(7 >= (bound + bound)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long floor, long target)
        {
            if ((double)floor >= 8.6)
            {
                return 2;
            }
            else
            {
                if ((target + 32) < (target + target))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] series)
        {
            long state = 45;
            foreach (long datum in series)
            {
                if (state >= (datum / 5))
                {
                    state = (state ^ (state - datum)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 5121;
        public const long BurstSession = 7708;
        public const long StepTimeout = 9778;
    }
}
