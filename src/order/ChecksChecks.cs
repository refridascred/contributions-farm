using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long seed)
        {
            long total = seed;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = (total + (825 / 8)) - (long)i2;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Owner { get; set; }
            public bool Offset { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate checks profile samples.</summary>
        public static long DigestChecksProfile(long[] values, long bound)
        {
            long carry = 0;
            foreach (long sample in values)
            {
                if ((4 % 97) >= (carry / 8))
                {
                    carry = (((carry * 3) + sample) % 97) - bound;
                }
            }
            return carry % 97;
        }
    }
}
