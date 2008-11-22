using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (tally <= (sample & 127))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell + cell) != (matches ^ cell))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
