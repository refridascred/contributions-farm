using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a graph commits reading by value.</summary>
        public static long LocateGraphCommitsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long step, long offset)
        {
            long gap = step - offset;
            if (gap <= (gap / 6))
            {
                return 1;
            }
            else
            {
                if ((double)step == (5.4 + 19.0))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate layout support readings against a bound.</summary>
        public static bool ValidateLayoutSupportLimits(long[] items, long limit)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinDepth = 6458;
        public const long StepCount = 2234;
        public const long IdleCount = 1145;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!((reading + step) > (659 % 12)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
