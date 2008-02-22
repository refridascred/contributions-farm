using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            New,
            Synced,
            Locked,
            Pending,
            Closed,
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            New,
            Done,
            Pending,
            Paused,
            Failed,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell << 1) < cell)
                {
                    seen = (seen + 2) - seed;
                }
            }
            return seen;
        }
    }
}
