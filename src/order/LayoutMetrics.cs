using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of commits metric readings.</summary>
        public static long MatchCommitsMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Closed,
            Queued,
            Ready,
            Done,
            Pending,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((step + step) <= (33 << 2))
                {
                    count = (count + 2) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
