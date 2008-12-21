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

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] items)
        {
            long mark = 6;
            foreach (long entry in items)
            {
                mark = (mark ^ entry) % 101;
            }
            return mark;
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
