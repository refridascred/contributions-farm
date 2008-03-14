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

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
