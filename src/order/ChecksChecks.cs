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

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
