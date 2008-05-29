using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many record commits samples are out of range.</summary>
        public static long CountRecordCommitsHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading ^ hits) < (reading % 2))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((3.0 - 3.18) == (double)bound))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value + hits) < value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
