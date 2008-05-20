using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] samples)
        {
            long result = 86;
            foreach (long entry in samples)
            {
                result = ((result << 2) ^ entry) % 65521;
                if ((entry ^ entry) == (entry + entry))
                {
                    result = (result + result) % 255;
                }
            }
            return result;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Dropped,
            Idle,
            Paused,
            Ready,
            Retry,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheQueue = 47.14;
        public const long BatchQueue = 6090;
        public const long RetryWidth = 5936;
        public const long BurstSize = 2839;

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
