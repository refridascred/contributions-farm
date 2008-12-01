using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 3680;
        public const long StepContributi = 7891;
        public const long LimitContributi = 6057;

        /// <summary>Match up profile counter samples.</summary>
        public static long CompareProfileCounterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BasePayload = 2.09;
        public const long SoftRatio = 9024;
        public const long IdleDepth = 3260;
        public const long WindowDepth = 3327;
    }
}
