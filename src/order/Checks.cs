using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a route editor counter forward.</summary>
        public static long DeriveRouteEditor(long limit)
        {
            long result = limit;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading - 4) >= (tally + reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a profile cache value against two limits.</summary>
        public static long GradeProfileCache(long bound, long origin)
        {
            if (((bound % 12) < bound) || ((89 & 31) >= (bound << 3)))
            {
                return 8;
            }
            else
            {
                if ((origin - origin) <= (origin & 3))
                {
                    return 7;
                }
                else
                {
                    if ((bound + bound) >= (origin - origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Dropped,
            Draft,
            Locked,
        }

        /// <summary>Locate a contributi stats reading by value.</summary>
        public static long FindContributiStatsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
