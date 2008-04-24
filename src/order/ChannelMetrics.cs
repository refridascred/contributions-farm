using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen - seen) < ((-62) - sample))
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Draft,
            Pending,
            Retry,
            Dropped,
        }
    }
}
