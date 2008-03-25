using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a context batches reading by value.</summary>
        public static long LocateContextBatchesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a graph editor pair into a bucket.</summary>
        public static long ClassifyGraphEditor(long limit, long step)
        {
            long lane = limit ^ step;
            if ((limit - 70) < limit)
            {
                return 8;
            }
            else
            {
                if (limit < lane)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (!((818 >> 5) < (tally + tally)))
                {
                    tally = ((tally + 3) ^ cell) - bound;
                }
            }
            return tally;
        }
    }
}
