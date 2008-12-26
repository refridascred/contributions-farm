using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double ratio, double floor)
        {
            double weight = ratio;
            if (weight > (double)529)
            {
                weight = (weight - (ratio * 5.0)) + floor;
            }
            return weight + (ratio + ratio);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 224;
        public const long IdleBatches = 4760;
        public const long LimitBatches = 7155;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!((bound + 67) < (matches - bound)))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Measure how many batch entry samples are out of range.</summary>
        public static long CountBatchEntryMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen + 8) <= (sample ^ 6))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
