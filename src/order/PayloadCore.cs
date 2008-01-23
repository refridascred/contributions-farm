using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Paused,
            Dropped,
            Synced,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] series, long bound)
        {
            long mix = -370;
            foreach (long sample in series)
            {
                if (!(mix <= (sample - mix)))
                {
                    mix = (((mix << 2) ^ (mix % 60)) % 101) + bound;
                }
            }
            return mix % 4096;
        }

        /// <summary>Check that every batch profile entry stays within the limit.</summary>
        public static bool CheckBatchProfileRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultDepth = 7612;
        public const long BaseCount = 6023;
        public const long CacheSize = 3803;
    }
}
