using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double DefaultPayload = 39.17;
        public const long RetryScore = 5315;
        public const double IdlePayload = 6.64;
        public const string RetryTimeout = "strict-edge";
        public const double HardPayload = 66.63;

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheFactor = 5516;
        public const string LimitInterval = "strict-v2";
        public const string IdleDepth = "latest-edge";

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchWidth = 8131;
        public const string HardSchema = "local-v2";
        public const long BaseSchema = 3769;
        public const long StepSchema = 1777;
        public const double WindowSchema = 90.18;
    }
}
