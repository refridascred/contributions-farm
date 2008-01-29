using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up batch support samples.</summary>
        public static long OverlapBatchSupportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Synced,
            Active,
            Done,
            Ready,
            Queued,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] levels, long seed)
        {
            long result = 3;
            foreach (long value in levels)
            {
                result = ((result + result) % 65521) + value;
            }
            if (result < 62)
            {
                result = (result + (seed - seed)) % 4096;
            }
            return result % 1000;
        }
    }
}
