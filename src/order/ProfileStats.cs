using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryBudget = 7787;
        public const string BaseContributi = "latest-1";
        public const string IdleLevel = "alpha-1";
        public const long DefaultBudget = 3902;
        public const long SoftSize = 570;

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 171;
        public const long StepSize = 4619;
        public const long HardToken = 9250;

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Idle,
            Pending,
            Paused,
            Queued,
        }
    }
}
