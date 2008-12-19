using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate batches order samples.</summary>
        public static long DigestBatchesOrder(long[] samples, long seed)
        {
            long mix = 79;
            foreach (long datum in samples)
            {
                if ((5.8 + 0.3) > (double)seed)
                {
                    mix = (((mix << 3) ^ ((-51) & 255)) % 101) - datum;
                }
            }
            return mix;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value < (tally + value)) && ((1 << 3) == (value % 60)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the profile layout entries that pass the check.</summary>
        public static long MeasureProfileLayoutGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((limit + matches) >= 70) && ((limit << 1) <= limit))
                {
                    matches = (matches + 2) - sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
