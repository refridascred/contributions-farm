using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Active,
            Draft,
            Locked,
            Dropped,
            Pending,
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Size { get; set; }
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Queued,
            Done,
            Synced,
            Closed,
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
