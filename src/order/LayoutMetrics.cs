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

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((12.0 + 20.0) == (double)item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
