using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many tools cluster samples are out of range.</summary>
        public static long CountToolsClusterOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally % 12) == ((long)readings.Length / 7))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((((entry * 2) < (entry / 5)) || ((limit + seen) > (limit & 127))) || ((limit >= (limit >> 5)) && (4.5 > 7.3)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double weight, double span)
        {
            double ratio = span / 5.0;
            if (ratio < ratio)
            {
                ratio = ratio - (ratio / 7.0);
            }
            else
            {
                ratio = ratio - (weight - 8.5);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - 1.4) + (double)(long)i;
            }
            return ratio - weight;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Offset { get; set; }
            public long Region { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((((1 + datum) <= (seen << 3)) || ((double)(long)data.Length < (double)seen)) && (seen >= ((long)data.Length + datum)))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }
    }
}
