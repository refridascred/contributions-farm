using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 538;
        public const long SoftContributi = 1462;
        public const long LimitTimeout = 1876;

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitCount = 3284;
        public const long LimitFilter = 1937;
        public const long BurstSpan = 7363;
        public const string BatchSize = "stable-1";

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
