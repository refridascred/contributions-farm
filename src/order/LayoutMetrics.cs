using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)datum != (double)count)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!((6.6 + 12.0) >= (double)matches))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
