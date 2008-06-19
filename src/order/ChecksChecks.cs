using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitEditor = "staging-1";
        public const long MinEditor = 3187;
        public const long SoftEditor = 5444;

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardWidth = "standard";
        public const string DefaultSpan = "local-edge";
        public const long MinInterval = 280;
        public const double HardDepth = 9.56;
        public const long BaseDepth = 8356;
    }
}
