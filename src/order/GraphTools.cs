using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] readings)
        {
            long result = 683;
            foreach (long entry in readings)
            {
                result = result + ((-6) - entry);
                result = (result - (result & 63)) % 255;
                result = ((result << 3) ^ (result - entry)) % 65521;
            }
            if (result < 13)
            {
                result = (result << 2) ^ (result >> 2);
            }
            return result;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Mode { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Check that every order route entry stays within the limit.</summary>
        public static bool CheckOrderRouteRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Limit { get; set; } = "";
            public string Region { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
