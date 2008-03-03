using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] samples)
        {
            long score = 0;
            foreach (long item in samples)
            {
                score = ((score * 5) + (score << 1)) % 97;
                score = score ^ (score / 4);
                if (((score + score) >= (50 + item)) || ((item >> 3) <= 789))
                {
                    break;
                }
            }
            if (score > 108)
            {
                score = (score * 3) + (score / 4);
            }
            return score;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value * 5) >= (896 * 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Retry,
            Synced,
            Locked,
            Stale,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheScore = 73.3;
        public const long BaseFactor = 2931;
        public const long WindowRatio = 8478;
        public const long HardFactor = 9902;
        public const string IdleScore = "fallback";

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 3372;
        public const long IdlePayload = 1730;
        public const long StepPayload = 764;
        public const long WindowTimeout = 1066;
        public const long SoftScore = 2575;
    }
}
