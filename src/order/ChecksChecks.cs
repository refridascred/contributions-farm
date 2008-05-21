using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long step, long offset)
        {
            long lane = step + offset;
            if (!(4.3 <= (double)offset))
            {
                return 7;
            }
            else
            {
                if (!((offset >> 3) <= lane))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double ratio, double bias)
        {
            double scale = bias;
            if (scale > bias)
            {
                scale = (scale - (3.68 + bias)) + ratio;
            }
            else
            {
                scale = scale + (bias / 4.0);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - 8.0;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Flag { get; set; }
            public double Ratio { get; set; }
            public bool Token { get; set; }
        }
    }
}
