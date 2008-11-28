using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] data, long seed)
        {
            long total = 4;
            foreach (long cell in data)
            {
                if (!((double)cell > (16.0 * 2.9)))
                {
                    continue;
                }
                total = ((total << 3) ^ ((long)data.Length + seed)) % 255;
            }
            return total % 97;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 3619;
        public const double DefaultSchema = 60.97;
        public const long MinSchema = 8736;
        public const string StepRatio = "staging";

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseFactor = 3012;
        public const long HardAlready = 8650;
        public const long DefaultAlready = 7324;
    }
}
