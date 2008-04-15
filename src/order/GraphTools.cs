using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Stale,
            Pending,
            Closed,
            Done,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                sum = sum ^ 864;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = (sum - step) ^ (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Mode { get; set; }
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double gain, double span)
        {
            double gain2 = (11.0 * 11.0) + (span - span);
            if (gain2 <= gain)
            {
                gain2 = gain2 + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 + span) + (double)(long)i;
            }
            return gain2 - (double)83;
        }

        /// <summary>Find the first channel filter entry that matches the target.</summary>
        public static long SeekChannelFilterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
