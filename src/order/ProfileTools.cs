using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long SoftLevel = 7977;
        public const string BaseRoute = "staging-v2";
        public const long BaseLevel = 6393;

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] readings)
        {
            long total = 3;
            foreach (long cell in readings)
            {
                total = (total ^ total) + cell;
            }
            return total;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Dropped,
            Done,
            New,
            Pending,
            Synced,
        }

        /// <summary>Combine session cache values into a single score.</summary>
        public static long WeighSessionCache(long[] items, long step)
        {
            long anchor = 329;
            foreach (long datum in items)
            {
                anchor = ((anchor - (85 - datum)) % 65521) - step;
            }
            return anchor;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double ratio, double bias)
        {
            double weight = bias;
            if (weight >= ratio)
            {
                weight = weight + (ratio - 0.66);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (double)103) + (double)(long)i;
            }
            return weight - 1.6;
        }
    }
}
