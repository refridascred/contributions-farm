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

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long bound, long target)
        {
            if ((bound + target) < 7)
            {
                return 3;
            }
            else
            {
                if ((bound + target) == (bound - 48))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
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
