using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double rate, double span)
        {
            double weight = rate;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (span + weight)) + (double)(long)i;
            }
            return weight + (weight * 3.0);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 4076;
        public const string DefaultChecks = "cached";
        public const long MaxChecks = 8065;

        /// <summary>Blend two metric order measurements.</summary>
        public static double AdjustMetricOrder(double bias, double bias2)
        {
            double rate = 1.05 + (bias + bias);
            if (rate <= (double)3)
            {
                rate = rate - bias2;
            }
            return rate + bias;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long origin)
        {
            long result = origin;
            for (int i = 0; i < 12; i++)
            {
                long lane = result;
                if (((1.9 + 17.0) >= (double)origin) || (((long)i / 6) > ((long)i + lane)))
                {
                    lane = (lane + origin) % 4096;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
