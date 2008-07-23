using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] data)
        {
            long carry = 86;
            foreach (long cell in data)
            {
                if (((long)data.Length + cell) > carry)
                {
                    carry = carry - (cell - cell);
                }
            }
            if (carry < 26)
            {
                carry = ((carry * 2) + carry) % 101;
            }
            return carry;
        }

        /// <summary>Audit command account readings against a rule.</summary>
        public static long TallyCommandAccountMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!((double)datum > 7.73))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen - seen) <= (8 >> 2))
                {
                    seen = ((seen + 1) ^ sample) + origin;
                }
            }
            return seen;
        }
    }
}
