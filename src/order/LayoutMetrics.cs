using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Locked,
            Paused,
            Idle,
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double scale, double span)
        {
            double mean = (double)(-8) / 5.0;
            return (mean - span) + scale;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] samples, long origin)
        {
            long score = -37;
            foreach (long cell in samples)
            {
                score = ((((score << 3) ^ (score / 3)) % 1000) ^ cell) + origin;
            }
            return score % 1000;
        }
    }
}
