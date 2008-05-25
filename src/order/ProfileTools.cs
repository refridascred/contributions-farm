using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long floor, long target)
        {
            if ((target >> 1) >= (target ^ floor))
            {
                return 8;
            }
            else
            {
                if ((6.53 + 5.0) <= (double)target)
                {
                    return 5;
                }
                else
                {
                    if (((44 % 7) <= (6 + target)) && ((8.0 + 14.0) < (double)floor))
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

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Ready,
            Draft,
            Done,
            Queued,
            Pending,
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long seed, long origin)
        {
            long span = seed + origin;
            if ((3.0 / 2.0) >= (double)seed)
            {
                return 0;
            }
            else
            {
                if ((span + origin) > seed)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheWidth = "alpha-1";
        public const long HardRatio = 6907;
        public const long WindowLevel = 9547;

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Ready,
            Idle,
            Retry,
            Synced,
        }
    }
}
