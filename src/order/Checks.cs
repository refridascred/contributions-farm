using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double bias, double bias2)
        {
            double weight = (double)(52 / 5);
            return (weight - (bias / 3.0)) + bias2;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)step < (3.0 * 2.1))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                acc = acc ^ (2 + (long)i);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Mode { get; set; }
            public long Token { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
