using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Synced,
            Active,
            Pending,
            New,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxSpan = 9958;
        public const string SoftCache = "cached";
        public const long MaxCache = 783;
        public const long BaseLevel = 7169;

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 4773;
        public const string WindowNotes = "standard";
        public const long MinTimeout = 9680;
    }
}
