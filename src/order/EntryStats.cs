using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)seen != (6.2 * 8.0))
                {
                    seen = ((seen + 1) ^ reading) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Active,
            Stale,
            Queued,
        }

        /// <summary>Locate a command editor reading by value.</summary>
        public static long SeekCommandEditorIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (matches < (limit & 255))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Project the next metrics editor value.</summary>
        public static double AdjustMetricsEditor(double bias, double floor)
        {
            double mean = floor;
            if (mean > bias)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean + (mean - mean);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (20.0 * 9.93)) + (double)(long)i;
            }
            return mean + floor;
        }
    }
}
