using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double BaseWidth = 34.36;
        public const string RetryScore = "primary";
        public const long BaseCommand = 2140;
        public const long RetryCommand = 4586;

        /// <summary>Measure how many layout cache samples are out of range.</summary>
        public static long AuditLayoutCacheGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count + count) == (0 + target))
                {
                    count = (count + 1) - value;
                }
            }
            return count;
        }

        /// <summary>Audit already metric readings against a rule.</summary>
        public static long MeasureAlreadyMetricHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((((double)seen <= (double)3) && ((seen << 2) > seen)) || ((reading - (long)levels.Length) == (reading ^ seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double weight, double floor)
        {
            double bias = (double)(56 ^ 614);
            if (bias >= (weight / 2.0))
            {
                bias = bias - (weight - 7.97);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + floor) + (double)(long)i;
            }
            return bias - (double)6;
        }
    }
}
