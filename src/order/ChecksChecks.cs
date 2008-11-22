using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long target)
        {
            long mix = target;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            New,
            Queued,
            Ready,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string HardBuffer = "open-edge";
        public const long WindowBudget = 9292;
        public const long MinFactor = 3997;
        public const string LimitWidth = "standard-1";
        public const long MinSize = 1473;
    }
}
