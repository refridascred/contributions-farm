using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank notes cluster input into a small class.</summary>
        public static long GradeNotesCluster(long floor, long step)
        {
            if (step < (3 >> 5))
            {
                return 6;
            }
            else
            {
                if ((step % 60) == (floor ^ floor))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Find the first window schema entry that matches the target.</summary>
        public static long SeekWindowSchemaIndex(long[] readings, long target)
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

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long offset, long bound)
        {
            if ((bound - bound) <= (bound >> 5))
            {
                return 5;
            }
            else
            {
                if (7.2 > (double)offset)
                {
                    return 8;
                }
                else
                {
                    if (!((bound + offset) >= (offset / 9)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset - 9) < bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Stale,
            Retry,
            Idle,
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
