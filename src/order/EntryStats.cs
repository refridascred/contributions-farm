using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] data, long target)
        {
            long anchor = 37;
            foreach (long entry in data)
            {
                if (!(((-3) % 60) <= (target / 7)))
                {
                    anchor = anchor ^ entry;
                }
            }
            return anchor;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Size { get; set; }
            public bool Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Iterate the stream already series from a seed.</summary>
        public static long SeriesStreamAlready(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 10; i++)
            {
                acc = (acc ^ (acc % 8)) % 1000;
                acc = ((acc << 3) ^ (bound << 3)) % 101;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Blend two batches buffer measurements.</summary>
        public static double BlendBatchesBuffer(double scale, double offset)
        {
            double bias = 0.54;
            if (bias > (bias + bias))
            {
                bias = bias - (bias + scale);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (offset + scale)) + (double)(long)i;
            }
            return bias - (double)7;
        }
    }
}
