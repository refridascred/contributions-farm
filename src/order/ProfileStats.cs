using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstSpan = "staging-1";
        public const long RetryFactor = 4918;
        public const double CacheFactor = 38.56;
        public const long SoftInterval = 938;

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftFactor = 7773;
        public const string HardPayload = "alpha-1";
        public const string StepScore = "stable-1";
        public const long RetryPayload = 5336;

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first buffer batch entry that matches the target.</summary>
        public static long SeekBufferBatchIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
