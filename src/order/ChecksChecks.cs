using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Paused,
            Idle,
            Retry,
            Failed,
            Queued,
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            New,
            Synced,
            Queued,
            Closed,
            Idle,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (value <= (seen ^ seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
