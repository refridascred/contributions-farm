using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every session format entry stays within the limit.</summary>
        public static bool VerifySessionFormatLimits(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry << 3) ^ (29 & 127)) % 101;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                acc = acc ^ acc;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxInterval = 850;
        public const long BurstStats = 5083;
        public const long DefaultStats = 2056;
        public const string BatchInterval = "alpha";
        public const double IdleSpan = 16.26;
    }
}
