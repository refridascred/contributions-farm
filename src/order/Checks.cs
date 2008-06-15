using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Mode { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Score { get; set; } = "";
            public string Label { get; set; } = "";
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Active,
            Paused,
            New,
            Draft,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long floor, long seed)
        {
            long cur = floor ^ seed;
            if (((14.0 * 19.0) < (double)seed) && ((double)floor <= (double)42))
            {
                return 7;
            }
            else
            {
                if ((floor - 2) == (floor - cur))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long bound, long target)
        {
            if (20.0 > (double)target)
            {
                return 5;
            }
            else
            {
                if ((bound - bound) > (bound >> 3))
                {
                    return 3;
                }
                else
                {
                    if ((0.59 / 2.0) <= (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)target < (8.0 / 4.0)) && ((target - bound) >= target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
