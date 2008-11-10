using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!((sample * 2) >= ((-608) << 3)) || (((sample >> 5) != (matches + sample)) || ((sample - sample) >= sample)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 17; i++)
            {
                acc = acc - (origin / 8);
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((16.0 * 0.8) > (double)hits)
                {
                    hits = ((hits + 1) ^ sample) + offset;
                }
            }
            return hits;
        }
    }
}
