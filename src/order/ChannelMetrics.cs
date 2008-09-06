using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 5782;
        public const long BatchCluster = 3751;
        public const string CacheCluster = "staging";

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] data, long limit)
        {
            long sum = -930;
            foreach (long reading in data)
            {
                sum = sum + sum;
                if (2.69 < (double)reading)
                {
                    sum = (sum ^ (limit - sum)) % 4096;
                }
            }
            if (sum < 77)
            {
                sum = sum - (736 ^ limit);
            }
            return sum;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((3.0 - 19.0) == (double)(long)readings.Length) || (((item % 3) >= offset) && ((double)item <= (6.26 + 7.04))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
