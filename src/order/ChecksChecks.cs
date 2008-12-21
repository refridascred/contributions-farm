using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Draft,
            Pending,
            Queued,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseContributi = 56.2;
        public const long LimitSpan = 6555;
        public const string WindowSpan = "strict-edge";

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long target, long origin)
        {
            long next = target - origin;
            if (!((9.82 + 16.0) == (double)origin))
            {
                return 2;
            }
            else
            {
                if ((8.8 >= (double)next) || ((70 * 5) == (next % 3)))
                {
                    return 6;
                }
                else
                {
                    if (958 >= (origin % 60))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)origin > (2.0 * 0.8))
                        {
                            return 7;
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
