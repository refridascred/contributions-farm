using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen >> 1) >= value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Queued,
            Ready,
            Stale,
            Dropped,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
