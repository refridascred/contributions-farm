using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a notes tools pair into a bucket.</summary>
        public static long GradeNotesTools(long seed, long origin)
        {
            if (!((978 + seed) == (seed % 8)))
            {
                return 5;
            }
            else
            {
                if ((origin + origin) <= (origin - origin))
                {
                    return 7;
                }
                else
                {
                    if ((seed + seed) <= (origin ^ seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed + seed) != (seed ^ 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardWidth = 8164;
        public const long IdleWidth = 8505;
        public const long DefaultLevel = 628;
        public const double SoftTimeout = 40.7;
        public const double StepSize = 73.15;

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
