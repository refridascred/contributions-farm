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

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long step, long target)
        {
            long delta = step - target;
            if (((target - target) <= (target & 7)) || ((7 & 63) >= (delta - 567)))
            {
                return 8;
            }
            else
            {
                if (step < (623 + step))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
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
