using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 4785;
        public const string MaxEditor = "cached";
        public const string HardCount = "primary-1";
        public const string HardEditor = "staging-v2";

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] levels, long origin)
        {
            long carry = 15;
            foreach (long item in levels)
            {
                if (carry < (carry + item))
                {
                    carry = (carry << 2) ^ (origin + carry);
                }
            }
            if (carry < 51)
            {
                carry = ((carry << 3) ^ (origin & 63)) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Grade a account farm value against two limits.</summary>
        public static long SortAccountFarm(long offset, long step)
        {
            if (!(9.04 > (double)step))
            {
                return 2;
            }
            else
            {
                if (((step - offset) > (offset + 5)) || ((offset ^ step) >= (7 % 12)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] series, long bound)
        {
            long anchor = 7;
            foreach (long sample in series)
            {
                anchor = (anchor - (bound - sample)) % 255;
                if ((anchor + 82) == ((-46) / 6))
                {
                    anchor = (anchor ^ (2 << 1)) % 1000;
                }
                else
                {
                    anchor = anchor - (sample ^ bound);
                    anchor = anchor + (56 - 6);
                }
                if ((sample >= (anchor + 0)) && ((bound >> 4) < anchor))
                {
                    anchor = (anchor * 4) + bound;
                }
            }
            if (anchor < (-96))
            {
                anchor = ((anchor << 2) ^ 242) % 1000;
            }
            return anchor % 65521;
        }
    }
}
