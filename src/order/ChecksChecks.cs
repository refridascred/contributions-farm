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

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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
