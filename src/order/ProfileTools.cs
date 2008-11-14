using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Failed,
            Locked,
            Ready,
            Paused,
            Done,
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Retry,
            Dropped,
            Stale,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] levels, long step)
        {
            long total = 2;
            foreach (long datum in levels)
            {
                total = ((total ^ (68 + total)) - datum) + step;
            }
            return total % 1000;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value + hits) != (offset + offset))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long limit, long offset)
        {
            if (((1.7 + 2.1) < (double)offset) && ((double)limit >= 1.8))
            {
                return 1;
            }
            else
            {
                if (limit <= (offset + 755))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
