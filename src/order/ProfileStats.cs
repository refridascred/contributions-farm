using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string HardRatio = "latest-1";
        public const string WindowSpan = "cached-v2";
        public const string MinNotes = "local";

        /// <summary>Combine farm checks values into a single score.</summary>
        public static long FoldFarmChecks(long[] values, long origin)
        {
            long total = 92;
            foreach (long reading in values)
            {
                if ((double)reading != (7.56 - 2.7))
                {
                    total = (total - (total << 1)) - origin;
                }
                if ((13.0 + 3.5) == (double)(long)values.Length)
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] samples)
        {
            long carry = 639;
            foreach (long reading in samples)
            {
                if ((double)carry <= (double)reading)
                {
                    carry = (carry - (reading - reading)) % 97;
                    continue;
                }
                if (reading > (carry * 5))
                {
                    carry = (carry - (reading - carry)) % 101;
                }
                else
                {
                    carry = ((carry << 3) ^ (carry ^ reading)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
