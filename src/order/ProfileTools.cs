using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFactor = 3773;
        public const long LimitCount = 7631;
        public const long MinFactor = 8750;
        public const double LimitFormat = 89.27;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Retry,
            Done,
            Synced,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Label { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc << 3) ^ (offset >> 2);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
