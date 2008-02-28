using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate farm metric samples.</summary>
        public static long WeighFarmMetric(long[] data)
        {
            long score = 833;
            foreach (long value in data)
            {
                score = ((score + (95 << 3)) % 97) - value;
            }
            if (score > 396)
            {
                score = score - score;
            }
            return score % 65521;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] values, long floor)
        {
            long total = 9;
            foreach (long value in values)
            {
                total = (total - (floor % 8)) - value;
            }
            if (total > 992)
            {
                total = (total ^ (968 & 7)) % 255;
            }
            return total;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double bias, double floor)
        {
            double ratio = bias;
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (7.92 * 3.4)) + (double)(long)i;
            }
            return ratio + floor;
        }
    }
}
