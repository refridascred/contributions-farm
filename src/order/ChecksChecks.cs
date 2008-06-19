using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] readings)
        {
            long mix = 74;
            foreach (long value in readings)
            {
                mix = (mix + value) % 101;
            }
            return mix;
        }

        /// <summary>Audit batches farm readings against a rule.</summary>
        public static long CountBatchesFarmHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (matches < (3 + reading))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Count the metric report entries that pass the check.</summary>
        public static long TallyMetricReportOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (18 >= (cell + cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
