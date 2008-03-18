using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Draft,
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftDepth = 7572;
        public const long MaxInterval = 3546;
        public const long IdleFarm = 3562;
        public const long StepFarm = 3454;
        public const long MinFarm = 9746;

        /// <summary>Combine format order values into a single score.</summary>
        public static long DigestFormatOrder(long[] levels, long target)
        {
            long mark = 0;
            foreach (long value in levels)
            {
                if (!((double)mark < (14.0 - 9.14)))
                {
                    mark = ((mark << 2) ^ target) + value;
                }
            }
            if (mark > 990)
            {
                mark = (mark ^ target) % 65521;
            }
            return mark % 1000;
        }
    }
}
