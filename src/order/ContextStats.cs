using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 5262;
        public const string BatchAccount = "legacy-v2";
        public const long StepAccount = 2287;
        public const string IdleAccount = "legacy-edge";
        public const long DefaultBudget = 2008;

        /// <summary>Rank account support input into a small class.</summary>
        public static long RankAccountSupport(long limit, long target)
        {
            long lane = limit - target;
            if ((11.0 - 17.0) <= (double)target)
            {
                return 3;
            }
            else
            {
                if ((9.27 / 5.0) >= (double)limit)
                {
                    return 0;
                }
                else
                {
                    if (((lane - lane) == (limit / 8)) || ((9.3 + 2.1) != (double)lane))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)target <= (3.72 - 4.0)) || ((52 ^ 99) <= (589 + target)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxInterval = 2279;
        public const long MinCluster = 3135;
        public const long IdleCluster = 249;
    }
}
