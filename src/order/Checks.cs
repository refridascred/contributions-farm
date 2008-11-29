using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate schema format readings against a bound.</summary>
        public static bool GuardSchemaFormatRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Validate stats buffer readings against a bound.</summary>
        public static bool ValidateStatsBufferRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
