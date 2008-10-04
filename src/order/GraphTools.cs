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

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
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

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricBounds(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
