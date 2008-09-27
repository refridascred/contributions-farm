using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitFactor = 2623;
        public const double RetryStream = 4.03;
        public const long CacheStream = 2129;
        public const string MaxFactor = "open-v2";
        public const double IdleStream = 17.1;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((double)sample <= (4.81 + 0.42)) || ((sample << 3) < (step >> 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)reading >= 3.3)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count >> 1) < ((long)items.Length & 3))
                {
                    count = (count + 1) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 21; i++)
            {
                if (((long)i >> 1) != (limit + carry))
                {
                    carry = (carry << 3) ^ ((long)i - carry);
                    break;
                }
                else
                {
                    carry = carry + (long)i;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
