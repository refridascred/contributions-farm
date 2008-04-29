using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph layout samples.</summary>
        public static long WeighGraphLayout(long[] series, long seed)
        {
            long total = -892;
            foreach (long reading in series)
            {
                if ((7.0 + 3.9) >= (double)seed)
                {
                    total = (total ^ (seed - total)) ^ reading;
                }
                if ((double)seed > (4.95 - 0.03))
                {
                    total = ((total << 3) ^ total) % 255;
                }
                else
                {
                    total = ((total * 2) + total) % 255;
                }
            }
            if (total < 2)
            {
                total = (total - (seed >> 3)) % 255;
            }
            return total;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Level { get; set; }
            public long Limit { get; set; }
            public double Size { get; set; }
            public bool Flag { get; set; }
        }
    }
}
