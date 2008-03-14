using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many metrics stream samples are out of range.</summary>
        public static long CountMetricsStreamHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits + hits) <= (hits >> 5))
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 6520;
        public const long CacheWidth = 2200;
        public const double DefaultCounter = 51.08;

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Done,
            Idle,
            Draft,
        }

        /// <summary>Iterate the cluster report series from a seed.</summary>
        public static long RollClusterReport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long seed, long origin)
        {
            if ((9.5 / 3.0) == (double)origin)
            {
                return 8;
            }
            else
            {
                if ((double)origin > (double)31)
                {
                    return 5;
                }
                else
                {
                    if ((seed * 3) == (8 + seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
