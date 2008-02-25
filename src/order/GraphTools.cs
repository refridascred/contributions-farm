using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Retry,
            Ready,
            Dropped,
            Done,
            New,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double gain, double offset)
        {
            double mean = (double)((-1) & 1);
            if (mean <= (5.0 * 5.7))
            {
                mean = ((mean - (double)85) + gain) - offset;
            }
            return mean + mean;
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

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((target ^ hits) < (cell - hits)) && !((double)cell > (14.0 / 9.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first counter editor entry that matches the target.</summary>
        public static long FindCounterEditorIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
