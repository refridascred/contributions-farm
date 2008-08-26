using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                carry = carry ^ limit;
                carry = (carry - (carry & 63)) % 97;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MinSession = "primary";
        public const long BatchSpan = 365;
        public const double HardCount = 47.87;

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
