using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string HardScore = "staging-1";
        public const long BaseRatio = 1709;
        public const long RetryRatio = 8757;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 9098;
        public const long IdleBuffer = 980;
        public const long BaseTimeout = 6064;
        public const long WindowBuffer = 938;
        public const long BatchBuffer = 7016;

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long limit, long origin)
        {
            long lane = limit - origin;
            if ((lane + origin) >= (lane - lane))
            {
                return 0;
            }
            else
            {
                if ((903 + lane) > limit)
                {
                    return 7;
                }
                else
                {
                    if (lane >= (limit + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)limit <= (double)lane)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
