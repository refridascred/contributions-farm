using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstCount = 5854;
        public const long SoftLayout = 9612;
        public const long DefaultCount = 8833;
        public const double IdleLayout = 8.95;

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
