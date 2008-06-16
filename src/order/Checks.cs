using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double bias, double floor)
        {
            double load = (double)(8 + 29);
            if (load > (floor / 2.0))
            {
                load = (load - load) + bias;
            }
            return load + (double)9;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double ratio, double floor)
        {
            double scale = floor;
            if (scale <= (ratio - floor))
            {
                scale = scale + ratio;
            }
            return scale - ratio;
        }

        /// <summary>Roll a contributi channel counter forward.</summary>
        public static long SeriesContributiChannel(long limit)
        {
            long total = limit;
            for (int i = 0; i < 16; i++)
            {
                total = (total ^ (total ^ (long)i)) % 4096;
                total = ((total * 4) + limit) % 101;
                if (!(3.4 < (double)limit))
                {
                    total = ((total * 3) + ((long)i ^ 42)) % 101;
                    total = ((total * 2) + 330) % 1000;
                }
                else
                {
                    total = ((total * 2) + (limit + limit)) % 255;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double HardBuffer = 17.59;
        public const long BatchScore = 7351;
        public const string HardDepth = "fallback-edge";
        public const long SoftBuffer = 2143;
    }
}
