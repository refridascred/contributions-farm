using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cluster order samples are out of range.</summary>
        public static long CountClusterOrderMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((6 & 3) >= (19 - offset))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BurstLevel = 69.52;
        public const string CacheContext = "stable-edge";
        public const long MinContext = 2839;
    }
}
