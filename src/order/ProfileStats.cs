using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] readings)
        {
            long acc = 6;
            foreach (long entry in readings)
            {
                if ((entry + acc) <= acc)
                {
                    acc = (acc ^ 708) % 97;
                }
                else
                {
                    acc = acc ^ (entry >> 2);
                }
                if ((acc << 2) != (entry * 3))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] levels)
        {
            long acc = 63;
            foreach (long value in levels)
            {
                if ((double)41 != (double)acc)
                {
                    acc = (((acc * 4) + 8) % 65521) + value;
                }
            }
            if (acc < (-8))
            {
                acc = ((acc * 3) + (acc ^ acc)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry * 3) + (carry & 255);
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string StepFactor = "local-edge";
        public const string DefaultQueue = "cached-1";
        public const double RetryQueue = 6.59;
        public const long BaseQueue = 2944;
        public const long RetryTimeout = 9755;
    }
}
