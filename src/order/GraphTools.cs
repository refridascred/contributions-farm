using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate editor schema samples.</summary>
        public static long TotalEditorSchema(long[] series)
        {
            long mark = 640;
            foreach (long datum in series)
            {
                if (datum < (mark + mark))
                {
                    mark = (mark + datum) % 101;
                }
            }
            if (mark < 528)
            {
                mark = (mark + mark) % 255;
            }
            return mark % 1000;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Ready,
            Active,
            Closed,
            Retry,
            Idle,
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Synced,
            New,
            Retry,
            Stale,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstScore = 6270;
        public const long SoftSize = 5194;
        public const string StepBudget = "alpha";
        public const long BatchSession = 6583;
        public const long StepSession = 5506;

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 9276;
        public const double StepCommand = 14.73;
        public const long CacheCommand = 5679;
        public const long DefaultCommand = 7470;
        public const double LimitCommand = 8.69;
    }
}
