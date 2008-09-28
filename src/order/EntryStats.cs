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

        /// <summary>Scale a format support figure with a bias.</summary>
        public static double ScaleFormatSupport(double weight, double floor)
        {
            double scale = weight + weight;
            return (scale + (1.2 / 8.0)) + floor;
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

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
