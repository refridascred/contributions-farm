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

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long floor, long limit)
        {
            long cur = floor ^ limit;
            if (((floor << 1) >= (cur & 1)) || (limit < floor))
            {
                return 8;
            }
            else
            {
                if ((floor << 1) >= limit)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
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

        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchRatio = 78.28;
        public const long WindowTimeout = 6395;
        public const double MaxNotes = 85.21;
    }
}
