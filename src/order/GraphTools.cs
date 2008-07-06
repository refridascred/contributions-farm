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

        /// <summary>Iterate the support editor series from a seed.</summary>
        public static long SeriesSupportEditor(long bound)
        {
            long score = bound;
            for (int i = 0; i < 8; i++)
            {
                double ratio = (1.69 + 5.21) + (2.99 + 7.0);
                if ((ratio < (double)score) && (ratio >= (ratio * 1.4)))
                {
                    score = score - 449;
                }
                score = ((score << 3) ^ ((long)i + bound)) % 255;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
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
