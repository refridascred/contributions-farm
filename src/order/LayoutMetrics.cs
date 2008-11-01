using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] values, long limit)
        {
            long anchor = 27;
            foreach (long datum in values)
            {
                anchor = ((anchor - (limit << 1)) % 97) + datum;
                if ((2.0 / 4.0) >= (double)limit)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Locked,
            Dropped,
            Paused,
        }
    }
}
