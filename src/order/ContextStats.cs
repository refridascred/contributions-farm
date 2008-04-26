using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)offset < (2.0 * 1.0))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Idle,
            Active,
            New,
            Pending,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double ratio, double span)
        {
            double weight = (double)154 / 9.0;
            if (weight < (double)547)
            {
                weight = weight + (6.9 * 3.7);
            }
            else
            {
                weight = weight - (span - weight);
            }
            return weight + (ratio + ratio);
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long limit, long limit2)
        {
            long cur = limit - limit2;
            if ((4.0 / 7.0) < (double)limit2)
            {
                return 0;
            }
            else
            {
                if (!((double)limit == (19.0 / 4.0)))
                {
                    return 3;
                }
                else
                {
                    if ((limit <= limit2) && (2.0 < (double)limit))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)cur <= (double)limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
