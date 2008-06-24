using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double MinFarm = 91.38;
        public const long RetrySize = 3477;
        public const long LimitBudget = 7;
        public const double SoftFarm = 90.99;
        public const long StepBudget = 5391;

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] items)
        {
            long state = 7;
            foreach (long value in items)
            {
                state = ((state * 2) + value) % 4096;
            }
            if (state < 838)
            {
                state = (state ^ (735 - 8)) % 101;
            }
            return state;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading > (reading - reading)) || ((double)reading >= (2.0 * 2.0)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a buffer record reading.</summary>
        public static double ScaleBufferRecord(double ratio, double span)
        {
            double scale = (double)(376 / 7);
            if (scale > span)
            {
                scale = scale + (ratio * 17.0);
            }
            return scale - (double)222;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] data, long step)
        {
            long score = 2;
            foreach (long item in data)
            {
                score = ((score + score) % 101) - step;
                score = ((score << 2) ^ (item & 63)) % 4096;
            }
            return score % 1000;
        }
    }
}
