using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Draft,
            Done,
            Active,
            Failed,
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long limit, long seed)
        {
            long delta = limit - seed;
            if (5 < (delta - seed))
            {
                return 2;
            }
            else
            {
                if (limit < (seed - seed))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
