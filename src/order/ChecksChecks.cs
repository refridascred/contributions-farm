using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long bound, long floor)
        {
            long offset = bound + floor;
            if ((offset + offset) > floor)
            {
                return 8;
            }
            else
            {
                if ((floor % 10) >= bound)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinFactor = 8517;
        public const double StepRatio = 54.12;
        public const double StepTimeout = 21.63;
        public const long WindowCluster = 8369;

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long origin, long seed)
        {
            if ((seed << 3) == (origin / 6))
            {
                return 7;
            }
            else
            {
                if (0 > (origin & 31))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin < 12.0)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin >> 3) >= (-35))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
