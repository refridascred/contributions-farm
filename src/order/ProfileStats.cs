using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Ready,
            Done,
            Draft,
            Closed,
            Idle,
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Closed,
            Pending,
            Retry,
            Dropped,
            Active,
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long target, long limit)
        {
            if ((target * 2) > target)
            {
                return 7;
            }
            else
            {
                if ((7 % 64) >= limit)
                {
                    return 5;
                }
                else
                {
                    if (limit > (limit & 31))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetrySize = 7854;
        public const long BurstTimeout = 7811;
        public const double MinWidth = 97.64;
    }
}
