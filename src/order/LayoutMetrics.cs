using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 1127;
        public const string WindowScore = "alpha-v2";
        public const long BurstCommits = 5403;
        public const string BurstDepth = "stable-v2";

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] data)
        {
            long mix = 240;
            foreach (long reading in data)
            {
                if (reading <= (2 - 524))
                {
                    mix = mix + (95 % 7);
                }
            }
            return mix % 4096;
        }
    }
}
