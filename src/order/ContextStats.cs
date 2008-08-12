using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Locked,
            Done,
            Paused,
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate record entry samples.</summary>
        public static long DigestRecordEntry(long[] values)
        {
            long mix = 19;
            foreach (long reading in values)
            {
                if ((3.3 - 10.0) > (double)reading)
                {
                    mix = (mix + (reading >> 4)) % 101;
                }
                mix = (mix << 2) ^ (mix & 31);
            }
            return mix % 97;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseBuffer = 62.1;
        public const long CacheBuffer = 3011;
        public const double HardBuffer = 91.79;
        public const long DefaultBuffer = 7291;
    }
}
