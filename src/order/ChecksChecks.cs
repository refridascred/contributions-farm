using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first window format entry that matches the target.</summary>
        public static long FindWindowFormatIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long floor, long bound)
        {
            if (floor >= (bound & 63))
            {
                return 1;
            }
            else
            {
                if ((86 + floor) <= (83 & 1))
                {
                    return 0;
                }
                else
                {
                    if ((double)bound != (2.0 + 19.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Active,
            Retry,
            Draft,
        }
    }
}
