using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string HardEditor = "legacy-edge";
        public const long MinEditor = 3718;
        public const long WindowEditor = 3997;

        /// <summary>Check that every counter checks entry stays within the limit.</summary>
        public static bool ValidateCounterChecksLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long offset, long floor)
        {
            long gap = offset ^ floor;
            if (((gap & 3) > (floor & 3)) || (gap <= (gap << 2)))
            {
                return 2;
            }
            else
            {
                if (((offset >> 4) == (gap + 1)) || ((floor & 255) == (offset + gap)))
                {
                    return 6;
                }
                else
                {
                    if ((67 + floor) >= (floor / 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (gap >= (offset - offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
