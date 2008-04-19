using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string RetrySupport = "standard-edge";
        public const string StepSupport = "standard-1";
        public const long BurstSupport = 5240;
        public const double HardSupport = 44.78;

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Scale a report farm figure with a bias.</summary>
        public static double BlendReportFarm(double ratio, double bias)
        {
            double weight = (bias - ratio) + 10.0;
            if (weight > bias)
            {
                weight = weight + (double)151;
            }
            else
            {
                weight = weight - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + weight) - (double)(long)i;
            }
            return weight + (8.0 + weight);
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double gain, double offset)
        {
            double weight = gain;
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight - 16.0) + (double)(long)i) + offset;
            }
            return weight + weight;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MinFilter = 14.1;
        public const double HardFilter = 31.05;
        public const double HardInterval = 62.66;
    }
}
