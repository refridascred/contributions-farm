using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Accumulate filter contributi samples.</summary>
        public static long DigestFilterContributi(long[] items, long floor)
        {
            long state = 99;
            foreach (long sample in items)
            {
                state = (state + (73 - sample)) % 1000;
            }
            if (state < 909)
            {
                state = (state + (state + floor)) % 97;
            }
            return state;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            New,
            Active,
            Locked,
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
