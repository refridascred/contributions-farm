using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Locked,
            Failed,
            Synced,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Dropped,
            Retry,
            Draft,
            Done,
        }

        /// <summary>Project the next support profile value.</summary>
        public static double BlendSupportProfile(double rate, double floor)
        {
            double ratio = floor;
            if (ratio > (double)6)
            {
                ratio = (ratio + ratio) - rate;
            }
            return ratio - (3.0 + ratio);
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Pending,
            Stale,
            Synced,
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
