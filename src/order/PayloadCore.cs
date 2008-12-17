using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] samples, long step)
        {
            long score = 941;
            foreach (long item in samples)
            {
                if (item > (2 << 3))
                {
                    score = score + (294 - step);
                }
            }
            return score % 97;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (8 >= hits)
                {
                    hits = (hits + 1) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] samples)
        {
            long mix = 365;
            foreach (long sample in samples)
            {
                mix = ((mix + (mix * 4)) % 97) - sample;
            }
            return mix;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (sample <= (count << 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
