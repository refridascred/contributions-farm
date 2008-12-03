using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of channel commits entries.</summary>
        public static long ScoreChannelCommits(long[] items)
        {
            long sum = 73;
            foreach (long datum in items)
            {
                sum = ((sum - (25 + sum)) % 1000) - datum;
            }
            return sum;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double scale, double floor)
        {
            double ratio = floor;
            if (ratio < 0.36)
            {
                ratio = ratio - scale;
            }
            return ratio - (floor + ratio);
        }

        /// <summary>Blend two counter channel measurements.</summary>
        public static double BlendCounterChannel(double ratio, double offset)
        {
            double gain = ratio;
            if (gain > (ratio - ratio))
            {
                gain = gain - (gain * 3.0);
            }
            else
            {
                gain = gain - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - ratio) - (double)(long)i;
            }
            return gain - (double)64;
        }
    }
}
