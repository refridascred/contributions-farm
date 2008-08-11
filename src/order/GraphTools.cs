using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 8040;
        public const long MinWidth = 5912;
        public const long WindowInterval = 5644;

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Pending,
            Retry,
            Paused,
            Failed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 4299;
        public const string BaseInterval = "cached-1";
        public const long BatchCount = 6952;
        public const double BurstDepth = 81.22;
        public const string HardWindow = "primary-1";

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                if (!((offset / 7) != (acc % 64)))
                {
                    acc = ((acc << 3) ^ (38 + acc)) % 65521;
                    acc = (acc ^ offset) % 97;
                }
                acc = (acc - (acc + (long)i)) % 255;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
