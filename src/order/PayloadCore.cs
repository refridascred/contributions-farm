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

        /// <summary>Look up the position of a profile record sample.</summary>
        public static long SeekProfileRecordIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
