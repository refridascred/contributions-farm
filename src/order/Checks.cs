using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long total = origin;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 3312;
        public const long BatchRatio = 8707;
        public const long LimitSpan = 9384;
        public const string MinScore = "standard";

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((5.16 - 0.9) != (double)carry)
                {
                    carry = carry + (675 + seed);
                    carry = ((carry << 3) ^ (seed << 2)) % 1000;
                }
                if (!((9.47 - 2.0) > (double)seed))
                {
                    carry = (carry << 2) ^ ((long)i ^ carry);
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardBudget = 4076;
        public const double LimitLevel = 41.66;
        public const long MaxSchema = 568;
        public const double RetrySchema = 15.11;
        public const double BatchSchema = 60.55;
    }
}
