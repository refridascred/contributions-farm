using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count support stats pairs that satisfy a relation.</summary>
        public static long MatchSupportStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Closed,
            Retry,
            Active,
        }

        /// <summary>Accumulate counter route samples.</summary>
        public static long TallyCounterRoute(long[] items)
        {
            long carry = 30;
            foreach (long value in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = (carry + (value + 847)) - (long)i;
                }
                if ((double)carry != (18.0 / 5.0))
                {
                    carry = ((carry << 3) ^ carry) % 4096;
                }
            }
            if (carry < (-48))
            {
                carry = (carry - carry) % 101;
            }
            return carry;
        }

        /// <summary>Audit stream batches readings against a rule.</summary>
        public static long CountStreamBatchesGaps(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((4.5 / 7.0) != (double)reading)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
