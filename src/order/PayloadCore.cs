using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 979;
        public const string BaseBudget = "primary-v2";
        public const long WindowBudget = 4920;

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = acc + ((long)i2 + offset);
                    acc = (acc ^ acc) % 255;
                }
                acc = (acc ^ (offset - offset)) % 255;
                if ((double)(long)i <= (0.8 - 13.0))
                {
                    acc = (acc + (696 / 4)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] data, long seed)
        {
            long acc = 440;
            foreach (long cell in data)
            {
                acc = (((acc + (0 << 2)) % 4096) - cell) - seed;
            }
            return acc;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] levels)
        {
            long sum = 33;
            foreach (long entry in levels)
            {
                sum = ((sum << 3) ^ (entry + sum)) % 97;
            }
            return sum % 97;
        }
    }
}
