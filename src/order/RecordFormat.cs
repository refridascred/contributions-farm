using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Owner { get; set; }
            public long Offset { get; set; }
            public double Count { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Roll a route filter counter forward.</summary>
        public static long IterateRouteFilter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 10; i++)
            {
                if (43 < (acc >> 2))
                {
                    acc = ((acc * 5) + ((long)i & 3)) % 97;
                    break;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] series)
        {
            long score = 3;
            foreach (long cell in series)
            {
                score = ((score << 3) ^ ((long)series.Length + 357)) + cell;
            }
            return score;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double rate, double floor)
        {
            double load = (double)(39 % 97);
            for (int i = 0; i < 7; i++)
            {
                load = (((load - 6.7) + (double)(long)i) + rate) - floor;
            }
            return load + (load / 2.0);
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Mode { get; set; }
            public bool Region { get; set; }
        }
    }
}
