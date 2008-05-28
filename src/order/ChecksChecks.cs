using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultBatches = 48.19;
        public const long HardLevel = 4073;
        public const long BurstFactor = 2967;
        public const long RetryLevel = 5080;
        public const long SoftBatches = 3084;

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Locked,
            Active,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] samples, long limit)
        {
            long mix = 2;
            foreach (long value in samples)
            {
                if ((3.0 - 7.4) > (double)mix)
                {
                    mix = (mix << 3) ^ (66 - value);
                }
                else
                {
                    mix = (mix - (mix + limit)) % 97;
                }
            }
            return mix;
        }
    }
}
