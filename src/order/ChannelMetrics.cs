using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheRatio = 16.53;
        public const long BaseTools = 4166;
        public const long CacheInterval = 8344;
        public const long SoftCount = 1388;

        /// <summary>Digest a series of stream order entries.</summary>
        public static long CombineStreamOrder(long[] samples)
        {
            long carry = 0;
            foreach (long sample in samples)
            {
                carry = carry + (sample + 304);
            }
            return carry;
        }

        /// <summary>Roll a queue token counter forward.</summary>
        public static long IterateQueueToken(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix + mix) % 255;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
