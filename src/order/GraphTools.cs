using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first stats contributi entry that matches the target.</summary>
        public static long LookupStatsContributiIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double bias, double offset)
        {
            double load = bias + (double)776;
            if (load < load)
            {
                load = load - (double)61;
            }
            else
            {
                load = load - (load * 20.0);
            }
            return load + offset;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Offset { get; set; }
            public bool Mode { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 95.61;
        public const long IdleWindow = 8702;
        public const string BatchWindow = "local";
        public const double HardWindow = 47.85;

        /// <summary>Blend two payload tools measurements.</summary>
        public static double SmoothPayloadTools(double weight, double floor)
        {
            double weight2 = (6.5 / 2.0) - (floor + weight);
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 + (weight + weight)) - (double)(long)i;
            }
            return weight2 - 1.9;
        }
    }
}
