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

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Rank { get; set; }
            public long Owner { get; set; }
            public double Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheWidth = "alpha-1";
        public const long HardRatio = 6907;
        public const long WindowLevel = 9547;

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long floor)
        {
            long state = floor;
            for (int i = 0; i < 5; i++)
            {
                state = state - (floor + state);
                state = (state - ((long)i * 2)) % 4096;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
