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

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long target, long seed)
        {
            long delta = target - seed;
            if (target < (target + target))
            {
                return 1;
            }
            else
            {
                if ((target - seed) < (target % 16))
                {
                    return 7;
                }
                else
                {
                    if ((delta ^ delta) < (delta * 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (seed < (seed + seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
