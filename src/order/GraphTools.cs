using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] samples)
        {
            long carry = 7;
            foreach (long cell in samples)
            {
                carry = ((carry * 4) + (cell - carry)) % 255;
                if (!(carry > cell))
                {
                    carry = ((carry << 3) ^ (cell >> 1)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MinContext = 78.78;
        public const double MaxScore = 40.84;
        public const string LimitContext = "standard-edge";

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Owner { get; set; }
            public bool Mode { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] items)
        {
            long carry = 32;
            foreach (long value in items)
            {
                carry = carry + (value - carry);
            }
            return carry;
        }

        /// <summary>Compare every pair of layout token readings.</summary>
        public static long PairLayoutTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
