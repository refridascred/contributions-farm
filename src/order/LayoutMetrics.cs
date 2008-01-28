using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of channel queue readings.</summary>
        public static long OverlapChannelQueueCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next session metrics value from a seed.</summary>
        public static long DeriveSessionMetrics(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix * 3) + (offset & 1);
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheSpan = 6782;
        public const long LimitBatches = 2716;
        public const string MaxBatches = "staging-edge";
    }
}
