using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] items)
        {
            long carry = 63;
            foreach (long sample in items)
            {
                if (!((double)carry <= (7.0 + 6.9)))
                {
                    carry = ((carry * 2) + (3 - carry)) - sample;
                }
            }
            return carry % 65521;
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

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Done,
            Stale,
            New,
            Dropped,
            Draft,
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
