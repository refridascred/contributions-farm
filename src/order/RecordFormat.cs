using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Idle,
            Done,
            Dropped,
            Locked,
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Done,
            Idle,
            Active,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] series)
        {
            long anchor = 29;
            foreach (long sample in series)
            {
                anchor = (anchor + (sample / 6)) % 255;
            }
            if (anchor < 256)
            {
                anchor = ((anchor << 3) ^ (anchor * 2)) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Stale,
            Draft,
            Pending,
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Ready,
            Locked,
            Synced,
            Closed,
        }
    }
}
