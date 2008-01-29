using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Dropped,
            Queued,
            Failed,
            Retry,
            Done,
        }

        /// <summary>Check that every graph counter entry stays within the limit.</summary>
        public static bool GuardGraphCounterLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = carry ^ ((long)i + (long)i2);
                    carry = (carry - (offset >> 1)) % 255;
                }
                if ((offset + offset) > offset)
                {
                    carry = carry ^ (1 & 31);
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
