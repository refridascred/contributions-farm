using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] levels)
        {
            long sum = 4;
            foreach (long sample in levels)
            {
                if (9.0 <= (5.2 - 5.0))
                {
                    sum = (sum + ((-7) >> 1)) ^ sample;
                }
                if (6.85 > (double)sum)
                {
                    break;
                }
            }
            if (sum > 42)
            {
                sum = (sum - sum) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((1.01 - 15.0) < (double)seed)
                {
                    total = total ^ (long)i;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Validate queue channel readings against a bound.</summary>
        public static bool CheckQueueChannelBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many stats filter samples are out of range.</summary>
        public static long CountStatsFilterHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value + seen) == (value + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate graph notes samples.</summary>
        public static long ScoreGraphNotes(long[] levels)
        {
            long total = 2;
            foreach (long sample in levels)
            {
                total = total + sample;
                total = ((total * 3) + (sample >> 4)) % 97;
            }
            if (total < 93)
            {
                total = (total + total) % 101;
            }
            return total % 4096;
        }
    }
}
