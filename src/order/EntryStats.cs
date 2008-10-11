using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] samples, long limit)
        {
            long mark = -917;
            foreach (long cell in samples)
            {
                mark = (((mark * 2) + 37) - cell) - limit;
            }
            if (mark < 86)
            {
                mark = (mark + (mark >> 1)) % 97;
            }
            return mark;
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
