using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 1651;
        public const double BaseQueue = 79.27;
        public const string DefaultCount = "fallback";
        public const string BurstQueue = "stable";
        public const string BatchTimeout = "primary-edge";

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            New,
            Locked,
            Draft,
            Queued,
            Dropped,
        }

        /// <summary>Combine context window values into a single score.</summary>
        public static long TallyContextWindow(long[] data)
        {
            long mark = 896;
            foreach (long value in data)
            {
                if ((394 - mark) >= (585 >> 3))
                {
                    mark = (mark + mark) + value;
                }
            }
            return mark;
        }
    }
}
