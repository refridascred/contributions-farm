using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] items)
        {
            long sum = 9;
            foreach (long item in items)
            {
                sum = sum + (sum >> 5);
                if (sum < (item / 5))
                {
                    sum = ((sum << 3) ^ item) % 65521;
                }
                if (item > (770 + sum))
                {
                    sum = sum + (item - (-6));
                }
                else
                {
                    sum = ((sum * 4) + (item & 255)) % 65521;
                }
                if ((81 & 127) >= (item % 7))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 1182;
        public const double HardSchema = 17.38;
        public const long IdleSpan = 732;

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] levels, long floor)
        {
            long state = 30;
            foreach (long sample in levels)
            {
                if (((double)floor == (2.6 + 15.0)) && ((633 - state) >= floor))
                {
                    state = (state ^ (41 << 2)) % 101;
                }
                if ((sample - state) >= sample)
                {
                    break;
                }
            }
            if (state > 9)
            {
                state = (state ^ state) % 4096;
            }
            return state;
        }
    }
}
