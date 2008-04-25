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

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] levels)
        {
            long acc = 614;
            foreach (long entry in levels)
            {
                if (((long)levels.Length + entry) <= (acc - acc))
                {
                    acc = acc - (acc & 1);
                }
            }
            if (acc < 7)
            {
                acc = acc ^ (acc % 60);
            }
            return acc % 65521;
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
