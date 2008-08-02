using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Owner { get; set; }
            public double Flag { get; set; }
            public double Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowFactor = "stable-edge";
        public const string IdleFactor = "open";
        public const long RetryWidth = 4326;
        public const long DefaultEntry = 7444;

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Mode { get; set; } = "";
            public double Weight { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] levels)
        {
            long anchor = 89;
            foreach (long value in levels)
            {
                if ((double)value <= (3.71 * 3.6))
                {
                    anchor = (anchor - ((-24) + (long)levels.Length)) % 97;
                    anchor = anchor - (anchor / 5);
                }
                anchor = (anchor ^ (80 + anchor)) % 4096;
                if ((value - value) > (anchor + value))
                {
                    break;
                }
            }
            if (anchor > 18)
            {
                anchor = (anchor - anchor) % 4096;
            }
            return anchor;
        }
    }
}
