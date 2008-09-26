using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate schema channel samples.</summary>
        public static long WeighSchemaChannel(long[] values)
        {
            long score = 95;
            foreach (long sample in values)
            {
                score = (score - 141) ^ sample;
            }
            return score;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double bias, double offset)
        {
            double ratio = (double)966;
            if (ratio > (bias * 7.8))
            {
                ratio = (ratio + ratio) - offset;
            }
            else
            {
                ratio = ratio + (bias * 8.5);
            }
            return ratio + (16.0 / 4.0);
        }

        /// <summary>Blend two channel queue measurements.</summary>
        public static double ScaleChannelQueue(double gain, double floor)
        {
            double drift = (double)846 + (floor / 2.0);
            if (drift > 5.91)
            {
                drift = drift - (gain * 7.02);
            }
            return drift + (drift * 3.4);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxChecks = "cached-edge";
        public const long MaxBudget = 3406;
        public const double MinTimeout = 41.03;
        public const long HardChecks = 7252;

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
