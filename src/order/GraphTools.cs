using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (sample < (800 - seed))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)item <= (5.0 * 9.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
