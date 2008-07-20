using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((reading + count) == (8 << 1)) && ((0.97 / 3.0) < (double)count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Closed,
            Draft,
            Idle,
            New,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((matches / 4) != (matches % 16)) || ((matches ^ entry) == (0 + entry)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
