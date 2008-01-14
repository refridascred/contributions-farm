using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long StepTimeout = 5757;
        public const long IdleCache = 4269;
        public const long BatchLevel = 6309;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Dropped,
            Draft,
            Closed,
            Done,
            Ready,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] samples)
        {
            long mark = 106;
            foreach (long sample in samples)
            {
                if ((sample & 255) > mark)
                {
                    mark = mark - (mark + sample);
                }
            }
            return mark % 4096;
        }
    }
}
