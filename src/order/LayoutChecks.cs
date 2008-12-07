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

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!(entry < (60 + entry)))
                {
                    count = count + 1;
                }
            }
            return count;
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

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 9352;
        public const long BatchInterval = 7951;
        public const long WindowBudget = 9671;
        public const double RetryScore = 58.62;
    }
}
