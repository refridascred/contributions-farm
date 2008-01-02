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

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] items)
        {
            long anchor = 918;
            foreach (long sample in items)
            {
                if (anchor > (sample << 2))
                {
                    anchor = (anchor ^ (sample % 97)) % 1000;
                }
            }
            if (anchor < 71)
            {
                anchor = (anchor << 2) ^ anchor;
            }
            return anchor % 97;
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
