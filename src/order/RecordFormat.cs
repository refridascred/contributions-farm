using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardBudget = 80.84;
        public const long LimitMetric = 7322;
        public const double MinSize = 37.77;

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((double)mark >= (6.0 * 7.0))
                {
                    mark = (mark ^ ((long)i + seed)) % 97;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((tally % 12) == (tally / 3)) || ((4.0 / 4.0) < (double)target))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
