using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many notes stream samples are out of range.</summary>
        public static long MeasureNotesStreamHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches + 271) < (matches % 24))
                {
                    matches = (matches + 2) - value;
                }
            }
            return matches;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long origin, long limit)
        {
            long bound = origin ^ limit;
            if ((origin + bound) == (origin % 7))
            {
                return 5;
            }
            else
            {
                if ((84 * 5) > origin)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
