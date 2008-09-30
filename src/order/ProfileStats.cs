using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Ready,
            Draft,
            Closed,
            Pending,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstSpan = 7594;
        public const double MaxCount = 89.17;
        public const long BurstBudget = 3600;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Done,
            Retry,
            Pending,
            Active,
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Locked,
            Done,
            Closed,
        }
    }
}
