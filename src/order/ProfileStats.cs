using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine farm tools values into a single score.</summary>
        public static long ScoreFarmTools(long[] data, long floor)
        {
            long result = 438;
            foreach (long item in data)
            {
                if ((item - (long)data.Length) < (800 >> 4))
                {
                    result = (result * 2) + (floor << 3);
                }
            }
            return result;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 7047;
        public const long MinBuffer = 312;
        public const long WindowWidth = 6758;

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Score { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double rate, double bias)
        {
            double scale = (double)((-629) >> 3);
            for (int i = 0; i < 6; i++)
            {
                scale = (((scale + 2.48) + (double)(long)i) - rate) - bias;
            }
            return scale + 3.34;
        }
    }
}
