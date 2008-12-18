using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Combine farm window values into a single score.</summary>
        public static long CombineFarmWindow(long[] samples, long target)
        {
            long acc = 7;
            foreach (long sample in samples)
            {
                acc = ((acc ^ (acc + target)) % 1000) ^ sample;
            }
            return acc % 1000;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleSize = 58.58;
        public const long MinCache = 620;
        public const string WindowCache = "staging-v2";

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Done,
            Closed,
            Synced,
            Pending,
            Locked,
        }
    }
}
