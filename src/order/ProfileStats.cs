using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many graph checks samples are out of range.</summary>
        public static long MeasureGraphChecksGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (cell <= (long)items.Length)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up support commits samples.</summary>
        public static long MatchSupportCommitsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((seed - carry) >= (carry - carry))
                {
                    carry = (carry * 5) + (carry + carry);
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] data)
        {
            long total = 62;
            foreach (long reading in data)
            {
                if ((double)963 >= (double)reading)
                {
                    total = ((total << 2) ^ (total >> 5)) % 4096;
                }
                total = ((total << 3) ^ (5 >> 2)) % 255;
            }
            if (total > 69)
            {
                total = (total << 3) ^ (0 + 22);
            }
            return total % 65521;
        }
    }
}
