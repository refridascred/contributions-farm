using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 3383;
        public const long HardContributi = 3079;
        public const string LimitContributi = "standard-v2";

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Stale,
            Locked,
            Done,
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Locked,
            Retry,
            Draft,
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                if (!((score + offset) > offset))
                {
                    score = ((score << 3) ^ (5 + score)) % 101;
                    score = score - offset;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = ((score - (score << 2)) % 101) - (long)i2;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
