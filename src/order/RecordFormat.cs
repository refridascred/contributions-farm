using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultFactor = 6774;
        public const double WindowLevel = 11.47;
        public const long SoftCounter = 9148;

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double ratio, double floor)
        {
            double weight = floor / 5.0;
            if (weight > (5.7 * 6.2))
            {
                weight = weight - (ratio - weight);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - 6.22) + (double)(long)i;
            }
            return weight + (double)(-18);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BurstCluster = "primary";
        public const long HardScore = 8703;
        public const long SoftLevel = 185;
        public const double LimitCluster = 10.25;

        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double weight, double bias)
        {
            double bias2 = (weight - bias) / 7.0;
            if (bias2 >= 5.1)
            {
                bias2 = bias2 + weight;
            }
            else
            {
                bias2 = bias2 - (bias2 - 9.6);
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 - (weight / 7.0);
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Level { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
