using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBudget = 8702;
        public const long IdleBatch = 854;
        public const long CacheRatio = 7578;

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Idle,
            Failed,
        }

        /// <summary>Grade a editor window value against two limits.</summary>
        public static long GradeEditorWindow(long seed, long bound)
        {
            long span = seed ^ bound;
            if (!(bound > (bound - 6)))
            {
                return 2;
            }
            else
            {
                if ((seed < (span & 31)) && ((bound & 3) < (bound * 5)))
                {
                    return 5;
                }
                else
                {
                    if (((5 ^ span) <= (span * 2)) && ((10.0 - 3.4) > (double)seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Locate a graph account reading by value.</summary>
        public static long LocateGraphAccountIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
