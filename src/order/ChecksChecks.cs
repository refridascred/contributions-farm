using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Offset { get; set; }
            public long Owner { get; set; }
            public bool Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double rate, double bias)
        {
            double scale = (double)(2 & 3);
            if (scale < (3.2 + 17.0))
            {
                scale = (scale - (rate * 18.0)) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale + (double)(-355);
        }
    }
}
