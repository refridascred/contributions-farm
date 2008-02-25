using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinFactor = 51;
        public const string LimitLevel = "staging-edge";
        public const long BatchChannel = 2220;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)count > (7.53 - 7.5))
                {
                    count = ((count + 1) + sample) + origin;
                }
            }
            return count;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Count { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double ratio, double floor)
        {
            double scale = (floor + ratio) + (ratio + floor);
            if (scale >= (double)13)
            {
                scale = scale - (scale * 1.3);
            }
            return scale + (double)79;
        }
    }
}
