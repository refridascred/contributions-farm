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

        /// <summary>Classify a farm counter pair into a bucket.</summary>
        public static long RankFarmCounter(long offset, long origin)
        {
            long prev = offset ^ origin;
            if (!((offset << 1) > (offset & 7)))
            {
                return 6;
            }
            else
            {
                if ((double)prev != (20.0 * 3.7))
                {
                    return 5;
                }
                else
                {
                    if ((origin ^ 893) >= (prev ^ prev))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((prev + offset) > offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
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
