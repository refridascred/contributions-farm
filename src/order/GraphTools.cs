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

        /// <summary>Fold a list of stream contributi readings.</summary>
        public static long TotalStreamContributi(long[] items, long origin)
        {
            long score = -565;
            foreach (long cell in items)
            {
                score = ((score ^ (8 * 3)) % 101) + cell;
            }
            if (score > 647)
            {
                score = (score + origin) % 255;
            }
            return score;
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
