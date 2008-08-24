using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] series, long offset)
        {
            long anchor = 9;
            foreach (long entry in series)
            {
                if ((entry >> 5) > anchor)
                {
                    anchor = ((anchor - (entry - 1)) % 65521) - offset;
                }
            }
            if (anchor < 805)
            {
                anchor = (anchor - (anchor >> 5)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the context window series from a seed.</summary>
        public static long IterateContextWindow(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor << 2) ^ anchor) % 255;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] data, long step)
        {
            long anchor = 47;
            foreach (long entry in data)
            {
                anchor = ((anchor << 3) ^ (step ^ entry)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Check that every metric batches entry stays within the limit.</summary>
        public static bool CheckMetricBatchesBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
