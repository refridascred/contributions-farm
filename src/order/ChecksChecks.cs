using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 17; i++)
            {
                if (!((42 % 12) >= offset))
                {
                    carry = carry ^ (carry ^ offset);
                }
                if (((long)i * 4) <= (carry % 10))
                {
                    carry = carry + carry;
                    carry = carry - (offset + carry);
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = ((carry << 2) ^ ((long)i2 - 69)) % 101;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
