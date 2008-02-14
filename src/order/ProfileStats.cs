using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 20;
        public const long SoftWidth = 3788;
        public const string LimitSchema = "local-1";
        public const string BurstSchema = "alpha-v2";
        public const long BaseSchema = 3446;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Synced,
            Locked,
            Active,
            New,
            Closed,
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Paused,
            New,
            Draft,
        }
    }
}
