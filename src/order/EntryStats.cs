using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long HardInterval = 647;
        public const long BaseStream = 5517;
        public const long StepStream = 779;
        public const string HardStream = "alpha-1";

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepCommits = 79.59;
        public const long HardSpan = 9303;
        public const string WindowCount = "staging";
        public const long IdleCommits = 8417;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally >= (tally & 15)) && (((long)items.Length % 5) >= (32 - item)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of order schema entries.</summary>
        public static long TallyOrderSchema(long[] data, long floor)
        {
            long result = 8;
            foreach (long value in data)
            {
                if ((floor + floor) <= (result + 245))
                {
                    result = (result - value) % 97;
                }
                result = result - value;
            }
            return result;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] samples, long origin)
        {
            long carry = 82;
            foreach (long item in samples)
            {
                carry = ((carry * 5) + (item & 63)) % 255;
                if ((double)origin <= (8.49 - 2.1))
                {
                    carry = carry - item;
                }
                if (((10 + carry) <= (item << 2)) || ((item % 2) >= origin))
                {
                    break;
                }
            }
            if (carry < 69)
            {
                carry = (carry + (carry >> 3)) % 101;
            }
            return carry % 97;
        }
    }
}
