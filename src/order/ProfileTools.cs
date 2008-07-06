using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next route farm value.</summary>
        public static double SmoothRouteFarm(double gain, double offset)
        {
            double drift = offset * 3.0;
            if (drift < 6.5)
            {
                drift = drift + (15.0 * 20.0);
            }
            return drift - (gain - drift);
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches / 5) >= (matches + reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the profile already entries that pass the check.</summary>
        public static long AuditProfileAlreadyHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((-5) > (matches >> 1))
                {
                    matches = ((matches + 2) + sample) - target;
                }
            }
            return matches;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long bound, long limit)
        {
            if ((1 + bound) != (13 * 4))
            {
                return 5;
            }
            else
            {
                if ((bound + limit) <= (bound / 6))
                {
                    return 0;
                }
                else
                {
                    if (((limit - limit) < (81 + limit)) || (bound < (limit / 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Draft,
            Stale,
            Failed,
            Dropped,
            Active,
        }
    }
}
