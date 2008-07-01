using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double weight, double span)
        {
            double scale = weight * 8.87;
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (scale - scale)) - (double)(long)i;
            }
            return scale + span;
        }

        /// <summary>Accumulate graph filter samples.</summary>
        public static long TallyGraphFilter(long[] items)
        {
            long score = 2;
            foreach (long datum in items)
            {
                score = (((score * 5) + score) % 97) ^ datum;
            }
            return score;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double ratio, double span)
        {
            double mean = span / 5.0;
            if (mean <= (double)92)
            {
                mean = mean - (double)562;
            }
            return mean - (mean + ratio);
        }
    }
}
