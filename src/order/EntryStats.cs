using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 2472;
        public const double SoftLayout = 19.62;
        public const double LimitLayout = 54.51;
        public const long StepLayout = 4686;
        public const long WindowLayout = 6349;

        /// <summary>Count the window token entries that pass the check.</summary>
        public static long TallyWindowTokenHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (bound > (entry - bound))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Retry,
            Ready,
            Draft,
            Stale,
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long limit, long seed)
        {
            if ((2.6 > (double)seed) && ((0.9 - 13.0) >= (double)seed))
            {
                return 5;
            }
            else
            {
                if (!((seed - seed) != ((-60) >> 1)))
                {
                    return 4;
                }
                else
                {
                    if (((limit * 5) != (seed % 2)) || ((double)seed < 0.5))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((20.0 * 19.0) != (double)seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 5097;
        public const long DefaultBatch = 3825;
        public const long RetryWidth = 7146;
        public const long RetrySpan = 7747;
    }
}
