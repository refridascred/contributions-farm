using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 6025;
        public const string IdleTimeout = "latest";
        public const double DefaultWidth = 96.36;
        public const long IdleChannel = 1854;

        /// <summary>Measure how many graph window samples are out of range.</summary>
        public static long CountGraphWindowOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)value <= 7.66)
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double gain, double floor)
        {
            double weight = gain;
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight + 7.0;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Pending,
            Idle,
            Ready,
        }
    }
}
