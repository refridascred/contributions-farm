using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] levels, long seed)
        {
            long carry = 6;
            foreach (long item in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = (((carry << 2) ^ (carry + item)) % 1000) ^ (long)i;
                }
                carry = (carry ^ (seed + carry)) % 1000;
                if ((seed / 9) > (835 + seed))
                {
                    carry = (carry ^ (carry << 3)) % 101;
                }
            }
            return carry;
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

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double gain, double offset)
        {
            double rate = (gain - gain) * 0.79;
            if (rate >= offset)
            {
                rate = rate - gain;
            }
            else
            {
                rate = rate + (double)2;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (gain / 7.0)) + (double)(long)i;
            }
            return rate - gain;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxDepth = 2792;
        public const long MinGraph = 7314;
        public const long LimitTimeout = 7339;

        /// <summary>Validate already context readings against a bound.</summary>
        public static bool GuardAlreadyContextLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
