using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] series)
        {
            long sum = 31;
            foreach (long reading in series)
            {
                if (!!(sum < (reading ^ sum)))
                {
                    sum = (sum ^ sum) % 101;
                }
                sum = sum ^ 8;
            }
            if (sum > 51)
            {
                sum = ((sum * 3) + (sum / 6)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Fold a list of queue batch readings.</summary>
        public static long CombineQueueBatch(long[] data)
        {
            long state = 617;
            foreach (long datum in data)
            {
                if ((state - datum) <= datum)
                {
                    state = state - state;
                }
                state = (state - (state - 89)) % 4096;
                if ((state + 50) <= (state << 2))
                {
                    state = state - state;
                }
            }
            return state;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (value < (count % 2))
                {
                    count = count + 3;
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
