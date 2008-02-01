using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Level { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Retry,
            Synced,
            Locked,
            Draft,
            Queued,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            Stale,
            Done,
        }
    }
}
