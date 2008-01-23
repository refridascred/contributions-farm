using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                long diff = carry + carry;
                if ((origin % 64) < (diff - diff))
                {
                    carry = carry - ((long)i + origin);
                }
                else
                {
                    carry = (carry - origin) % 255;
                }
                carry = (carry - (long)i) % 101;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Project the next buffer counter value.</summary>
        public static double ProjectBufferCounter(double weight, double offset)
        {
            double load = 20.0 * 9.0;
            return ((load - load) + weight) + offset;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Owner { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
        }
    }
}
