using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double ratio, double floor)
        {
            double weight = 2.3;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight + weight) + (double)(long)i) - ratio;
            }
            return weight - (floor * 4.82);
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] series, long bound)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (bound < (bound + 28))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Mode { get; set; } = "";
            public long Level { get; set; }
            public double Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
