using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen & 3) <= cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = ((state + (long)i) % 65521) + (long)i2;
                }
                if (((state - state) > seed) || ((double)seed <= (7.18 - 1.7)))
                {
                    state = ((state << 3) ^ ((long)i >> 5)) % 1000;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepLevel = "strict";
        public const long IdleRatio = 626;
        public const long CacheInterval = 52;
        public const string LimitEntry = "open-edge";

        /// <summary>Roll a counter stats counter forward.</summary>
        public static long IterateCounterStats(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry * 5) + (carry << 3);
                carry = ((carry << 2) ^ ((long)i + 61)) % 4096;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = (carry ^ floor) - (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Synced,
            Active,
            Ready,
        }
    }
}
