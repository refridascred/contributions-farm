using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultScore = 9522;
        public const long MinOrder = 1763;
        public const long LimitSize = 1568;
        public const long MinTimeout = 3773;
        public const long BatchFactor = 5062;

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCount = 3204;
        public const long LimitCache = 1048;
        public const long LimitScore = 9723;
        public const long BaseSize = 8288;
        public const string BatchSpan = "standard";
    }
}
