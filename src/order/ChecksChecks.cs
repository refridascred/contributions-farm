using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Pending,
            Draft,
            Paused,
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Synced,
            Stale,
            Retry,
            Locked,
            Closed,
        }
    }
}
