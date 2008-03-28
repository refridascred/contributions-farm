using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowDepth = 7252;
        public const long MinCounter = 1523;
        public const string StepCounter = "staging";
        public const double HardCounter = 80.54;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
