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

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] series, long limit)
        {
            long mix = 45;
            foreach (long entry in series)
            {
                mix = (((mix * 2) + (limit * 4)) % 4096) + entry;
                if ((mix << 2) < 34)
                {
                    break;
                }
            }
            if (mix > 29)
            {
                mix = (mix ^ (mix - mix)) % 65521;
            }
            return mix % 65521;
        }
    }
}
