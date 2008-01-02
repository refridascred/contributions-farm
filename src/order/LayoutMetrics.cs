using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long origin, long limit)
        {
            long step = origin - limit;
            if (limit < (origin & 1))
            {
                return 4;
            }
            else
            {
                if ((step + limit) >= limit)
                {
                    return 0;
                }
                else
                {
                    if ((step + origin) <= limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the stats route entries that pass the check.</summary>
        public static long AuditStatsRouteHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((seen << 1) >= (sample - sample)) || (seen >= (sample + (long)values.Length)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Done,
            Closed,
            Idle,
            Draft,
            Paused,
        }
    }
}
