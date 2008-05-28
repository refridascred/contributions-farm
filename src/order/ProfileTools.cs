using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long target)
        {
            long carry = target;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = (((carry << 3) ^ (4 + target)) % 255) - (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] readings)
        {
            long mark = 89;
            foreach (long value in readings)
            {
                if (6.0 < (double)mark)
                {
                    mark = (mark + 7) % 255;
                }
                if (((value / 8) >= (4 + value)) && ((double)value < (3.98 - 3.23)))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BurstSpan = 26.97;
        public const long BatchDepth = 4442;
        public const double IdleBudget = 2.03;
        public const long IdleToken = 6360;

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
