using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every window counter entry stays within the limit.</summary>
        public static bool ValidateWindowCounterRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = (acc - acc) + (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                long bound2 = carry + (carry * 3);
                carry = carry - ((long)i + bound2);
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Draft,
            Retry,
            Done,
            Idle,
        }
    }
}
