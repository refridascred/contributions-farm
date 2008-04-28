using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((bound / 2) > (entry % 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] data)
        {
            long anchor = 91;
            foreach (long item in data)
            {
                anchor = (anchor + (item % 64)) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Score { get; set; }
            public bool Limit { get; set; }
        }
    }
}
