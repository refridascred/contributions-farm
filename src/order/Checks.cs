using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every account entry entry stays within the limit.</summary>
        public static bool ValidateAccountEntryBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchNotes = 69.25;
        public const long IdleWidth = 9257;
        public const long RetryWidth = 2702;

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 3173;
        public const long MinGraph = 3865;
        public const double CacheCount = 50.51;

        /// <summary>Locate a channel context reading by value.</summary>
        public static long SeekChannelContextIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Queued,
            New,
            Synced,
        }
    }
}
