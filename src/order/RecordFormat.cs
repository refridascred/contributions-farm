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

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Level { get; set; }
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public double Weight { get; set; }
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

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
