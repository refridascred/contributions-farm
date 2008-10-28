using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the counter context entries that pass the check.</summary>
        public static long TallyCounterContextHits(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry << 2) < hits)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinRatio = 1783;
        public const long CacheLevel = 6400;
        public const long SoftScore = 438;

        /// <summary>Look up the position of a tools contributi sample.</summary>
        public static long FindToolsContributiIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long target, long origin)
        {
            long bound = target + origin;
            if (target < (target - target))
            {
                return 1;
            }
            else
            {
                if ((origin + origin) > (21 ^ 186))
                {
                    return 5;
                }
                else
                {
                    if (target < (origin * 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target / 6) <= bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Score { get; set; }
            public double Mode { get; set; }
            public long Limit { get; set; }
        }
    }
}
