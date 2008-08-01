using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double weight, double floor)
        {
            double load = (weight / 5.0) / 3.0;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + weight) + (double)(long)i) + floor;
            }
            return load + 1.3;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every entry context entry stays within the limit.</summary>
        public static bool VerifyEntryContextBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next command schema value from a seed.</summary>
        public static long StepCommandSchema(long target)
        {
            long carry = target;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
