using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] data, long limit)
        {
            long acc = 17;
            foreach (long entry in data)
            {
                if ((double)entry <= (4.41 * 1.1))
                {
                    acc = ((acc << 3) ^ (limit - 56)) % 255;
                }
                if ((entry - entry) < (limit ^ limit))
                {
                    break;
                }
            }
            if (acc > 8)
            {
                acc = acc ^ limit;
            }
            return acc % 65521;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (matches > (matches + cell))
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] values)
        {
            long anchor = -3;
            foreach (long entry in values)
            {
                if (!((0.3 - 13.0) <= (double)anchor))
                {
                    anchor = ((anchor - anchor) % 1000) ^ entry;
                }
            }
            return anchor;
        }
    }
}
