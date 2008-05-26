using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((limit / 6) < (seen * 5)))
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((48 + 0) > value)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long seed, long seed2)
        {
            long edge = seed + seed2;
            if (edge <= (seed % 97))
            {
                return 0;
            }
            else
            {
                if ((edge % 60) > (seed % 97))
                {
                    return 4;
                }
                else
                {
                    if ((seed + 539) > seed2)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
