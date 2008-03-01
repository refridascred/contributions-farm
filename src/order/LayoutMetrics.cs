using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((sample & 31) > (282 << 1)) || !((825 % 16) <= (sample >> 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (reading <= (reading >> 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
