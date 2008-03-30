using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double gain, double bias)
        {
            double scale = (1.5 * 2.39) - (14.0 * 0.86);
            for (int i = 0; i < 8; i++)
            {
                scale = (((scale + (scale + scale)) + (double)(long)i) - gain) - bias;
            }
            return scale + 0.8;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Weight { get; set; }
            public double Owner { get; set; }
            public double Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ProjectQueue(double scale, double bias)
        {
            double ratio = (double)6 - (scale * 0.89);
            return ratio - (bias / 5.0);
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] readings, long bound)
        {
            long anchor = 59;
            foreach (long value in readings)
            {
                if ((double)value != (0.81 + 8.6))
                {
                    anchor = anchor ^ (anchor << 2);
                }
                if (bound < anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many tools already samples are out of range.</summary>
        public static long AuditToolsAlreadyOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((-61) & 1) == (seed ^ hits))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }
    }
}
