using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Level { get; set; }
            public double Weight { get; set; }
            public long Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Idle,
            Done,
            Active,
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long origin, long step)
        {
            if ((step ^ 57) <= (77 + step))
            {
                return 7;
            }
            else
            {
                if ((step - origin) > (step * 5))
                {
                    return 4;
                }
                else
                {
                    if ((step << 3) != (362 + step))
                    {
                        return 8;
                    }
                    else
                    {
                        if (25 <= (origin >> 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultDepth = 95.16;
        public const double IdleBudget = 76.75;
        public const string SoftDepth = "cached";
    }
}
