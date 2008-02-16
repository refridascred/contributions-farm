using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long target, long seed)
        {
            long slot = target - seed;
            if ((target < (target + slot)) || (slot > (seed * 5)))
            {
                return 4;
            }
            else
            {
                if ((seed >> 4) == (target & 255))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen % 10) == (target ^ 24))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)item <= (double)matches)
                {
                    matches = (matches + 1) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                result = (result - result) % 1000;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Flag { get; set; }
            public bool Total { get; set; }
            public string Level { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
