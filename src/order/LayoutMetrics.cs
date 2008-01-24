using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a checks context pair into a bucket.</summary>
        public static long GradeChecksContext(long offset, long bound)
        {
            long lane = offset + bound;
            if ((double)offset <= (9.0 + 9.0))
            {
                return 1;
            }
            else
            {
                if ((bound & 15) <= (bound + lane))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
