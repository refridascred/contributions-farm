using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 5225;
        public const long DefaultCommits = 9288;
        public const long HardFactor = 1757;
        public const long MaxSize = 7504;
        public const double CacheInterval = 34.64;

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Ready,
            Draft,
            Paused,
            Retry,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] levels)
        {
            long total = 151;
            foreach (long datum in levels)
            {
                if (((datum + total) < datum) || (total < (total << 2)))
                {
                    total = ((total << 3) ^ total) % 65521;
                }
            }
            if (total > 48)
            {
                total = total + (total & 63);
            }
            return total;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinContext = "standard-v2";
        public const long BaseContext = 4386;
        public const long LimitDepth = 3626;

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] data, long origin)
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
    }
}
