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

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long step, long offset)
        {
            if ((double)step > (2.87 / 8.0))
            {
                return 8;
            }
            else
            {
                if ((step >> 4) > (offset / 4))
                {
                    return 7;
                }
                else
                {
                    if (offset > (step % 12))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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
