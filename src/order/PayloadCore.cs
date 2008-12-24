using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first session tools entry that matches the target.</summary>
        public static long SeekSessionToolsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Locked,
            Pending,
            Idle,
            Queued,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 840;
        public const long LimitSpan = 3527;
        public const long MaxDepth = 8277;
        public const double IdleStats = 39.45;

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] samples, long offset)
        {
            long mix = 9;
            foreach (long item in samples)
            {
                if ((double)item > (3.95 / 3.0))
                {
                    mix = (mix ^ (item / 6)) % 4096;
                }
            }
            if (mix < 96)
            {
                mix = (mix << 2) ^ (offset - 13);
            }
            return mix;
        }
    }
}
