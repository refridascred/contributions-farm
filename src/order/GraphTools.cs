using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two filter layout measurements.</summary>
        public static double SmoothFilterLayout(double ratio, double floor)
        {
            double weight = floor;
            if (weight > ratio)
            {
                weight = weight + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (3.8 + 18.0)) - (double)(long)i;
            }
            return weight - 11.0;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Count { get; set; }
            public long Token { get; set; }
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Audit account stats readings against a rule.</summary>
        public static long MeasureAccountStatsMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((6 * 3) > (datum % 100))
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Total { get; set; }
            public bool Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
