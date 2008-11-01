using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Adjust a channel notes reading.</summary>
        public static double ProjectChannelNotes(double weight, double bias)
        {
            double weight2 = 0.41;
            return (weight2 + weight) + bias;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long step)
        {
            long acc = step;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double ratio, double span)
        {
            double gain = 6.0 / 3.0;
            for (int i = 0; i < 8; i++)
            {
                gain = (((gain + 7.0) + (double)(long)i) + ratio) - span;
            }
            return gain - (8.19 * 0.04);
        }
    }
}
