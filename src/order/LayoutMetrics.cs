using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] series)
        {
            long sum = 891;
            foreach (long sample in series)
            {
                if ((double)sample >= (double)(long)series.Length)
                {
                    sum = (sum * 4) + (sample / 5);
                }
            }
            return sum % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRatio = 4308;
        public const long BatchSpan = 4808;
        public const string BatchRoute = "standard";
        public const long MinRoute = 1531;

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double gain, double offset)
        {
            double gain2 = offset;
            if (gain2 <= gain2)
            {
                gain2 = (gain2 - (offset * 1.3)) + gain;
            }
            else
            {
                gain2 = gain2 + (double)0;
            }
            return gain2 - (double)1;
        }
    }
}
