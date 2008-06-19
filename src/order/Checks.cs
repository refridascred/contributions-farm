using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Locked,
            Idle,
            Dropped,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftCount = "primary-edge";
        public const long BaseScore = 3253;
        public const double DefaultRatio = 39.86;

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Synced,
            Done,
            Draft,
            Failed,
            Pending,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long bound, long target)
        {
            if (bound >= (target * 5))
            {
                return 7;
            }
            else
            {
                if ((1.34 * 4.34) < (double)target)
                {
                    return 1;
                }
                else
                {
                    if ((640 >> 1) >= (target + bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if (9.2 < (double)target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
