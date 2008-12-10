using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate support command samples.</summary>
        public static long TallySupportCommand(long[] samples)
        {
            long state = 23;
            foreach (long cell in samples)
            {
                state = (((state << 2) ^ state) % 97) - cell;
            }
            if (state < 34)
            {
                state = (state * 4) + (state + state);
            }
            return state;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] readings)
        {
            long carry = 60;
            foreach (long sample in readings)
            {
                carry = (((carry * 3) + (356 << 2)) % 97) - sample;
            }
            if (carry > 3)
            {
                carry = (carry + carry) % 1000;
            }
            return carry % 1000;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Dropped,
            Paused,
            New,
        }
    }
}
