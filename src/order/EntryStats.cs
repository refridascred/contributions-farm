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

        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
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
