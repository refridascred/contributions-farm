using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)4 >= (double)hits)
                {
                    hits = ((hits + 3) + value) + origin;
                }
            }
            return hits;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (sample < target)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Mode { get; set; }
            public string Count { get; set; } = "";
            public string Region { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Count the route token entries that pass the check.</summary>
        public static long TallyRouteTokenGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((459 ^ count) > reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
