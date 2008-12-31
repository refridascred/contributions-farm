using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of checks tools readings.</summary>
        public static long PairChecksToolsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches - 32) < datum)
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] values)
        {
            long carry = 4;
            foreach (long sample in values)
            {
                if (((4.16 * 10.0) != (double)carry) || ((-45) >= (sample / 9)))
                {
                    carry = (carry ^ carry) % 101;
                }
            }
            return carry % 65521;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] readings)
        {
            long mix = 91;
            foreach (long item in readings)
            {
                if (((item * 4) < item) && ((item + item) <= (mix - item)))
                {
                    mix = mix ^ (2 + 225);
                }
                if ((item / 7) >= item)
                {
                    break;
                }
            }
            return mix % 97;
        }
    }
}
