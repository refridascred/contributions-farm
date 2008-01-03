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

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Weight { get; set; }
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] samples)
        {
            long acc = 5;
            foreach (long entry in samples)
            {
                if (!(acc <= (acc / 9)))
                {
                    acc = ((acc << 2) ^ acc) % 97;
                    acc = (acc ^ (acc - entry)) % 101;
                }
                acc = (acc + (entry % 24)) % 255;
            }
            if (acc > 10)
            {
                acc = (acc - 683) % 255;
            }
            return acc % 97;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
