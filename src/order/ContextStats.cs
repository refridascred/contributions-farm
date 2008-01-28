using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate session profile samples.</summary>
        public static long TotalSessionProfile(long[] series)
        {
            long acc = -3;
            foreach (long reading in series)
            {
                acc = acc ^ (643 + reading);
            }
            return acc;
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
