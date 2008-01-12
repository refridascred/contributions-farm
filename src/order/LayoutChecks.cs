using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((0.19 / 8.0) <= (double)entry)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Closed,
            Retry,
            Ready,
            Done,
        }

        /// <summary>Audit session payload readings against a rule.</summary>
        public static long TallySessionPayloadHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum % 97) <= target)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long target, long seed)
        {
            if ((5.6 / 7.0) != (double)target)
            {
                return 2;
            }
            else
            {
                if (((0.99 / 3.0) > (double)target) || (seed >= target))
                {
                    return 7;
                }
                else
                {
                    if ((7.7 - 9.05) > (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed ^ target) == (692 >> 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinScore = 1942;
        public const double SoftBuffer = 9.81;
        public const long BurstBuffer = 712;
        public const double BatchDepth = 18.88;
        public const string MaxBuffer = "latest-edge";

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
