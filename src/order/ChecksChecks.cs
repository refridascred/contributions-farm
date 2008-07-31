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

        /// <summary>Check that every record schema entry stays within the limit.</summary>
        public static bool CheckRecordSchemaRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
