using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample & 7) > (sample - 752))
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double bias, double floor)
        {
            double ratio = (double)(8 % 10);
            if (ratio < floor)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (ratio + bias)) + (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Find the first batches batch entry that matches the target.</summary>
        public static long LookupBatchesBatchIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Idle,
            Draft,
            Queued,
            Done,
            Closed,
        }
    }
}
