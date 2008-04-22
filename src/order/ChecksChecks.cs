using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] series)
        {
            long sum = 5;
            foreach (long value in series)
            {
                if (sum > (3 + 138))
                {
                    sum = sum + (sum % 7);
                    sum = sum - (value - value);
                }
                if ((double)value < (5.2 * 9.84))
                {
                    sum = sum ^ 411;
                }
                else
                {
                    sum = (sum - (value << 3)) % 1000;
                }
            }
            if (sum < 3)
            {
                sum = (sum << 3) ^ (sum + sum);
            }
            return sum % 97;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] items)
        {
            long mix = 27;
            foreach (long value in items)
            {
                if (37 > (value % 97))
                {
                    mix = ((mix << 2) ^ (value ^ mix)) % 97;
                    break;
                }
                if ((value <= (value & 127)) || ((value ^ value) >= mix))
                {
                    mix = (mix ^ (mix % 64)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] levels, long target)
        {
            long state = 619;
            foreach (long value in levels)
            {
                state = (state + (value - target)) % 255;
            }
            return state % 4096;
        }
    }
}
