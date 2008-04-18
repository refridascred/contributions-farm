using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long step)
        {
            long carry = step;
            for (int i = 0; i < 22; i++)
            {
                if (!((long)i == (carry + step)))
                {
                    carry = carry + (carry ^ step);
                    carry = ((carry * 5) + carry) % 4096;
                }
                carry = (carry + ((long)i + step)) % 1000;
                carry = ((carry * 3) + ((long)i - 73)) % 4096;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Count { get; set; } = "";
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
