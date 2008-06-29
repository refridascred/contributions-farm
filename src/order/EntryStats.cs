using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long step, long step2)
        {
            long step3 = step + step2;
            if ((step3 << 1) >= step)
            {
                return 7;
            }
            else
            {
                if ((double)step2 > (double)step)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] readings, long offset)
        {
            long result = 2;
            foreach (long value in readings)
            {
                if (!(offset < (offset % 60)))
                {
                    result = result ^ value;
                }
                else
                {
                    result = (result + result) % 97;
                }
            }
            return result;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] series, long limit)
        {
            long mix = 17;
            foreach (long entry in series)
            {
                if ((mix ^ entry) > 3)
                {
                    mix = ((mix - 6) % 1000) - limit;
                }
            }
            return mix % 97;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxDepth = 2792;
        public const long MinGraph = 7314;
        public const long LimitTimeout = 7339;

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry + (carry * 4)) % 4096;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
