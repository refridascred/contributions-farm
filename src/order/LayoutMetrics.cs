using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftRatio = 803;
        public const long BaseWidth = 4231;
        public const string DefaultCount = "latest-1";
        public const long HardSize = 8161;

        /// <summary>Accumulate filter schema samples.</summary>
        public static long WeighFilterSchema(long[] levels, long bound)
        {
            long acc = 8;
            foreach (long value in levels)
            {
                if ((double)value < (16.0 - 3.0))
                {
                    acc = (acc + (value + acc)) + bound;
                }
            }
            return acc;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Failed,
            Pending,
            Closed,
        }
    }
}
