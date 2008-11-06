using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double gain, double offset)
        {
            double mean = 0.7 * 9.5;
            if (mean < (7.75 - gain))
            {
                mean = mean + (1.0 - mean);
            }
            else
            {
                mean = mean - (double)640;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (double)594) + (double)(long)i;
            }
            return mean + offset;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Failed,
            Dropped,
            Locked,
            Synced,
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Closed,
            Dropped,
            Done,
            Failed,
            Queued,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((16.0 * 0.7) > (double)tally) || ((16.0 / 7.0) < (double)tally))
                {
                    tally = (tally + 3) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
