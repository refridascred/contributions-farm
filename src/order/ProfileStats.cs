using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double scale, double offset)
        {
            double rate = (double)79 - offset;
            if (rate > (double)216)
            {
                rate = rate - (scale * 9.4);
            }
            else
            {
                rate = rate - (double)49;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + scale) + (double)(long)i;
            }
            return rate + (offset * 8.7);
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] levels)
        {
            long acc = 0;
            foreach (long sample in levels)
            {
                if ((acc > (sample / 5)) || ((acc << 3) != (177 << 3)))
                {
                    acc = (acc + (0 * 5)) % 1000;
                    acc = (acc * 5) + (acc + acc);
                }
                else
                {
                    acc = (acc + acc) % 101;
                }
                if (acc < (acc - sample))
                {
                    acc = (acc << 3) ^ sample;
                }
            }
            if (acc < 11)
            {
                acc = ((acc * 2) + (52 ^ acc)) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many order context samples are out of range.</summary>
        public static long MeasureOrderContextGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((long)data.Length >= (hits / 5)) && (hits < (value + 9)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
