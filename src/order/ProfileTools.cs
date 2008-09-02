using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 1004;
        public const double MaxCount = 29.26;
        public const long BatchSchema = 6794;
        public const long StepDepth = 4207;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Locate a format profile reading by value.</summary>
        public static long LocateFormatProfileIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
