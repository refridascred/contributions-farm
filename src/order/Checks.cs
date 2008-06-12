using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first batch counter entry that matches the target.</summary>
        public static long LocateBatchCounterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (6.8 >= (double)(long)samples.Length)
                {
                    tally = ((tally + 2) ^ sample) + offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Failed,
            Stale,
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Done,
            Dropped,
            Stale,
            Closed,
            Paused,
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double ratio, double floor)
        {
            double scale = ratio;
            if (scale <= (double)41)
            {
                scale = (scale + (ratio / 3.0)) - floor;
            }
            return scale + scale;
        }
    }
}
