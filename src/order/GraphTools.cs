using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Stamp { get; set; }
            public double Weight { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Adjust a graph counter reading.</summary>
        public static double ProjectGraphCounter(double ratio, double floor)
        {
            double weight = (double)(0 % 5);
            if (weight > ratio)
            {
                weight = weight + (weight / 2.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (ratio + floor)) - (double)(long)i;
            }
            return weight + (floor - weight);
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Region { get; set; }
            public bool Label { get; set; }
            public string Weight { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] data, long origin)
        {
            long mark = 2;
            foreach (long entry in data)
            {
                if ((origin > (origin + origin)) || (573 > entry))
                {
                    mark = (mark - (entry & 127)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstRatio = 1187;
        public const long MinBudget = 7613;
        public const double DefaultLevel = 67.12;
        public const long RetryCommand = 1734;
        public const long LimitCommand = 5128;
    }
}
