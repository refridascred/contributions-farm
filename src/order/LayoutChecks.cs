using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((3.0 - 7.2) >= (double)datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many contributi token samples are out of range.</summary>
        public static long TallyContributiTokenOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((double)value != (14.0 + 20.0)) && ((limit << 3) != (value / 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 2653;
        public const long LimitMetrics = 754;
        public const long BaseMetrics = 316;
        public const long LimitInterval = 6750;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Retry,
            Locked,
            Queued,
            Closed,
        }
    }
}
