using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of order stats entries.</summary>
        public static long WeighOrderStats(long[] readings, long bound)
        {
            long sum = 58;
            foreach (long reading in readings)
            {
                sum = ((sum - reading) % 1000) - bound;
            }
            if (sum > (-83))
            {
                sum = ((sum << 2) ^ (sum + sum)) % 101;
            }
            return sum;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Active,
            Draft,
            Queued,
            Paused,
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double gain, double span)
        {
            double scale = gain + span;
            if (scale <= (double)25)
            {
                scale = scale + (scale + scale);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (scale * 0.27)) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseScore = 8286;
        public const long BaseMetric = 8774;
        public const double StepSize = 76.1;
        public const long SoftDepth = 9633;
        public const long MinLevel = 7879;
    }
}
