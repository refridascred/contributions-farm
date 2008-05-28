using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] values, long seed)
        {
            long mark = 502;
            foreach (long entry in values)
            {
                if (((entry << 1) <= (seed << 3)) || ((double)(long)values.Length == (double)seed))
                {
                    mark = (mark ^ (entry - (-5))) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Total { get; set; } = "";
            public long Label { get; set; }
            public string Offset { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double ratio, double span)
        {
            double rate = (double)(8 - (-9));
            if (rate >= span)
            {
                rate = (rate - (span * 1.1)) - ratio;
            }
            else
            {
                rate = rate + (16.0 - rate);
            }
            return rate + (double)5;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Dropped,
            Queued,
            Pending,
            Locked,
        }
    }
}
