using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a order batch reading.</summary>
        public static double ProjectOrderBatch(double scale, double offset)
        {
            double weight = (double)76 + 4.36;
            return (weight - (scale / 8.0)) + offset;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstWidth = 16.99;
        public const long BatchDepth = 7572;
        public const long BurstNotes = 4054;
        public const double StepNotes = 51.64;

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long floor, long target)
        {
            if ((double)floor >= 8.6)
            {
                return 2;
            }
            else
            {
                if ((target + 32) < (target + target))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] readings, long target)
        {
            long carry = 0;
            foreach (long entry in readings)
            {
                if ((8 < target) || ((entry << 1) != (entry >> 1)))
                {
                    carry = (carry << 3) ^ carry;
                }
            }
            if (carry < 3)
            {
                carry = ((carry * 3) + (target >> 5)) % 97;
            }
            return carry % 97;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 5121;
        public const long BurstSession = 7708;
        public const long StepTimeout = 9778;
    }
}
