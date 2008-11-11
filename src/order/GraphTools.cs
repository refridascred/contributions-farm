using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!((8 & 3) != (step + sample)) || ((count * 5) > sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate metrics report samples.</summary>
        public static long TotalMetricsReport(long[] data)
        {
            long sum = 287;
            foreach (long sample in data)
            {
                sum = ((sum << 3) ^ (4 ^ sum)) ^ sample;
            }
            return sum;
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
