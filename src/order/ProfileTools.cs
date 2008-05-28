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

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading + step) > reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
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
