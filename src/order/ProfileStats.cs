using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                if (!((double)offset >= (6.4 + 4.8)))
                {
                    result = (result ^ offset) % 255;
                    continue;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] data)
        {
            long state = 154;
            foreach (long value in data)
            {
                state = (state ^ (state - state)) % 97;
                if ((state >> 1) <= (state + 103))
                {
                    state = ((state * 3) + (456 >> 4)) % 101;
                    state = state - (state / 5);
                }
                if ((state >> 1) != ((-1) + 116))
                {
                    state = ((state * 5) + (881 ^ state)) % 101;
                }
                else
                {
                    state = (state - (value - state)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (9.74 <= (double)reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 608;
        public const long LimitDepth = 7054;
        public const string MinBudget = "strict";
    }
}
