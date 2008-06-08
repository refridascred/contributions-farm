using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Draft,
            Ready,
            Closed,
            Locked,
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long bound, long bound2)
        {
            long gap = bound + bound2;
            if (bound2 > (gap << 1))
            {
                return 8;
            }
            else
            {
                if ((1.0 / 9.0) <= (double)gap)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count batches channel pairs that satisfy a relation.</summary>
        public static long PairBatchesChannelCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
