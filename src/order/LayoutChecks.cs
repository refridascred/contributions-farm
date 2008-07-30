using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double weight, double span)
        {
            double scale = weight;
            if (scale <= (weight / 6.0))
            {
                scale = scale - (double)629;
            }
            return scale + (span + weight);
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample * 4) < (507 ^ sample))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit stream githubfarm readings against a rule.</summary>
        public static long MeasureStreamGithubfarmGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((double)datum >= (2.34 * 1.5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public bool Size { get; set; }
        }
    }
}
