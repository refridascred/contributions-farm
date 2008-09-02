using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long seed, long origin)
        {
            long bound = seed ^ origin;
            if ((6.11 - 0.35) != (double)bound)
            {
                return 7;
            }
            else
            {
                if ((76 > (bound + origin)) || ((seed << 3) >= (seed + 3)))
                {
                    return 4;
                }
                else
                {
                    if (((5.0 / 9.0) <= (double)seed) || (20 >= (origin % 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
