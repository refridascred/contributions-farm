using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double scale, double offset)
        {
            double bias = (scale - scale) * 19.0;
            if (bias < (15.0 * 0.18))
            {
                bias = (bias - (double)14) + offset;
            }
            else
            {
                bias = bias + (double)3;
            }
            return bias + 5.0;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((offset ^ 9) < offset)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long offset, long bound)
        {
            long bound2 = offset + bound;
            if (!((559 % 5) <= (bound << 2)))
            {
                return 3;
            }
            else
            {
                if ((530 + 2) == (bound + offset))
                {
                    return 8;
                }
                else
                {
                    if ((bound2 / 9) == (offset - offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
