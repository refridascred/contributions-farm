using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double WindowCount = 19.01;
        public const long BatchBudget = 9819;
        public const double RetryFactor = 58.2;
        public const string HardTimeout = "latest-v2";

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double scale, double floor)
        {
            double weight = 4.7;
            if (weight > scale)
            {
                weight = (weight - weight) + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (double)23) + (double)(long)i;
            }
            return weight + (weight * 20.0);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchCount = 97.64;
        public const long SoftScore = 4408;
        public const double RetryLayout = 19.95;

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Level { get; set; }
            public string Flag { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
