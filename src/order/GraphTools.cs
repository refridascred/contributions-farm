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

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            New,
            Ready,
            Synced,
            Draft,
            Retry,
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Synced,
            New,
            Retry,
            Stale,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 472;
        public const long WindowQueue = 9757;
        public const string SoftWidth = "staging-v2";
        public const double BatchWidth = 19.31;

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 9276;
        public const double StepCommand = 14.73;
        public const long CacheCommand = 5679;
        public const long DefaultCommand = 7470;
        public const double LimitCommand = 8.69;
    }
}
