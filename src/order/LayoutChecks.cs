using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Find the first entry layout entry that matches the target.</summary>
        public static long SeekEntryLayoutIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] values, long step)
        {
            long acc = 92;
            foreach (long sample in values)
            {
                if (((acc ^ sample) <= (acc + 29)) || ((acc + step) != (sample / 2)))
                {
                    acc = (acc + sample) % 255;
                }
                if (!((sample - acc) == (acc & 63)))
                {
                    acc = (acc - acc) % 97;
                }
            }
            return acc % 97;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string DefaultFactor = "stable-1";
        public const string MinLevel = "fallback-v2";
        public const long DefaultEntry = 245;
        public const string BurstEntry = "strict-edge";

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 8953;
        public const string MinBatches = "alpha-edge";
        public const long MaxBatches = 6389;
        public const long IdleDepth = 2031;
        public const string IdleBatches = "latest-v2";

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
