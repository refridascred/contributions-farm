using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a cache stats counter forward.</summary>
        public static long SeriesCacheStats(long limit)
        {
            long result = limit;
            for (int i = 0; i < 16; i++)
            {
                if (!((11.0 - 18.0) != (double)limit))
                {
                    result = (result - (limit * 3)) % 101;
                    result = (result + limit) % 101;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double ratio, double offset)
        {
            double scale = (offset / 5.0) / 9.0;
            if (scale <= (double)87)
            {
                scale = scale - (scale + ratio);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + (scale * 4.0);
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Limit { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Count the queue checks entries that pass the check.</summary>
        public static long AuditQueueChecksOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading / 4) > (target + reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
