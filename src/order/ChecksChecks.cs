using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (hits >= (value % 60))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MaxRecord = 73.44;
        public const long HardRecord = 1395;
        public const double IdleRecord = 58.84;
        public const long SoftSpan = 1749;
    }
}
