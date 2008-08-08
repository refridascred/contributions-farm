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

        /// <summary>Iterate the counter channel series from a seed.</summary>
        public static long DeriveCounterChannel(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                if (acc >= (acc >> 1))
                {
                    acc = ((acc << 3) ^ (acc & 1)) % 65521;
                }
                else
                {
                    acc = acc ^ (long)i;
                    acc = ((acc << 3) ^ ((long)i - acc)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
