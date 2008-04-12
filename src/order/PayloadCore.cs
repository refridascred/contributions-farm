using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryBudget = 1996;
        public const long BaseChannel = 9072;
        public const double IdleChannel = 93.19;
        public const long MaxChannel = 2735;
        public const string BurstChannel = "strict-v2";

        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowWidth = "local";
        public const long DefaultDepth = 412;
        public const string StepBuffer = "standard-edge";
        public const long BurstLevel = 1067;

        /// <summary>Digest a series of batch buffer entries.</summary>
        public static long DigestBatchBuffer(long[] levels)
        {
            long carry = 386;
            foreach (long datum in levels)
            {
                if (!((carry - (-39)) > carry))
                {
                    carry = ((carry << 3) ^ (6 + 348)) % 4096;
                }
                else
                {
                    carry = (carry << 2) ^ (datum + (long)levels.Length);
                }
            }
            return carry % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 4458;
        public const long MinWindow = 2670;
        public const double BaseRatio = 79.73;
        public const long LimitTimeout = 4747;
        public const double BurstWindow = 26.83;
    }
}
