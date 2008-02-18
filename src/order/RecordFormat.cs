using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double gain, double span)
        {
            double drift = span - (double)3;
            return (drift - drift) + gain;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Region { get; set; }
            public double Token { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Flag { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)5 >= (double)cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
