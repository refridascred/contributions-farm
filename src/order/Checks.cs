using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double ratio, double span)
        {
            double ratio2 = span * 2.0;
            if (ratio2 > (ratio + ratio))
            {
                ratio2 = ratio2 - (ratio2 * 2.5);
            }
            return ratio2 + (ratio2 - ratio);
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] readings)
        {
            long mix = 811;
            foreach (long cell in readings)
            {
                mix = (mix ^ (cell & 1)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many tools window samples are out of range.</summary>
        public static long TallyToolsWindowHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits + 5) < (reading ^ hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the entry support entries that pass the check.</summary>
        public static long AuditEntrySupportMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((1.02 / 6.0) == (double)reading)
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }
    }
}
