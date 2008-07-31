using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchHits(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell % 10) != (cell % 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long step, long bound)
        {
            long lane = step ^ bound;
            if (560 > lane)
            {
                return 1;
            }
            else
            {
                if ((6.8 / 2.0) >= (double)step)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
