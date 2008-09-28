using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] items, long origin)
        {
            long anchor = 722;
            foreach (long value in items)
            {
                if (value < (anchor << 2))
                {
                    anchor = (anchor + value) % 255;
                    anchor = ((anchor * 2) + anchor) % 101;
                    break;
                }
                anchor = (anchor << 3) ^ (value + origin);
            }
            return anchor;
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

        /// <summary>Match up checks githubfarm samples.</summary>
        public static long CompareChecksGithubfarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
