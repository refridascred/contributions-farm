using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 5499;
        public const long DefaultOrder = 6961;
        public const long BaseOrder = 6020;

        /// <summary>Accumulate stream window samples.</summary>
        public static long ScoreStreamWindow(long[] values, long step)
        {
            long carry = 285;
            foreach (long item in values)
            {
                carry = (((carry << 3) ^ (carry ^ step)) % 65521) - item;
            }
            if (carry > 0)
            {
                carry = (carry + (step + 840)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
