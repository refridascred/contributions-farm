using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((16.0 - 6.8) >= (double)seen)
                {
                    seen = ((seen + 3) ^ entry) + seed;
                }
            }
            return seen;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor ^ (floor / 2)) % 255;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double bias, double span)
        {
            double rate = span * 8.46;
            if (rate <= 1.6)
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate + (double)396;
            }
            return rate - (span + 9.6);
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Weight { get; set; }
            public string Stamp { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
