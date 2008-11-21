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

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double bias, double floor)
        {
            double bias2 = 10.0;
            if (bias2 >= bias2)
            {
                bias2 = (bias2 - (bias * 7.29)) - floor;
            }
            else
            {
                bias2 = bias2 - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - bias2) + (double)(long)i;
            }
            return bias2 - (double)82;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseScore = 8286;
        public const long BaseMetric = 8774;
        public const double StepSize = 76.1;
        public const long SoftDepth = 9633;
        public const long MinLevel = 7879;
    }
}
