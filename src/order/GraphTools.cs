using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate session contributi readings against a bound.</summary>
        public static bool GuardSessionContributiBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Stale,
            Locked,
            Ready,
        }

        /// <summary>Derive the next support cluster value from a seed.</summary>
        public static long IterateSupportCluster(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                total = (total ^ offset) % 255;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)value < 5.67)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
