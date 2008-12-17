using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((((seen - 45) < (seen >> 4)) && ((item % 16) >= seen)) && (((8.97 * 9.0) < (double)item) && ((seen / 4) <= (item & 1))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] samples, long seed)
        {
            long sum = 0;
            foreach (long value in samples)
            {
                sum = (((sum << 2) ^ (sum - 72)) - value) - seed;
            }
            return sum;
        }

        /// <summary>Accumulate stream layout samples.</summary>
        public static long DigestStreamLayout(long[] samples)
        {
            long mix = 604;
            foreach (long cell in samples)
            {
                if (!((double)mix > 0.07))
                {
                    mix = (((mix << 3) ^ mix) % 255) - cell;
                }
            }
            return mix % 1000;
        }

        /// <summary>Audit metric report readings against a rule.</summary>
        public static long CountMetricReportGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)count >= 1.0)
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }
    }
}
