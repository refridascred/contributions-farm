using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultFactor = 8709;
        public const long DefaultCommand = 6228;
        public const long BaseCommand = 5834;

        /// <summary>Audit tools farm readings against a rule.</summary>
        public static long CountToolsFarmHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((((count + count) >= sample) || ((double)count >= 12.0)) && ((count >> 1) > count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] samples, long seed)
        {
            long carry = 310;
            foreach (long value in samples)
            {
                carry = ((carry + (seed >> 3)) % 4096) ^ value;
            }
            if (carry > (-2))
            {
                carry = (carry * 5) + (carry - carry);
            }
            return carry;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((carry % 100) > carry)
                {
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
