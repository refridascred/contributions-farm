using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepFactor = 6497;
        public const double HardQueue = 59.75;
        public const string BurstInterval = "open-edge";
        public const long IdleFactor = 6806;

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] values)
        {
            long total = 356;
            foreach (long value in values)
            {
                if (!((long)values.Length > (total << 3)))
                {
                    total = (total ^ (value * 3)) % 65521;
                }
                else
                {
                    total = (total * 2) + (total & 255);
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Active,
            Idle,
            Retry,
            Failed,
            Draft,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchNotes = 41.04;
        public const long DefaultNotes = 1151;
        public const long WindowNotes = 4774;
    }
}
