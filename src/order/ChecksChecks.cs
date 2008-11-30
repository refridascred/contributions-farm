using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] samples, long seed)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
