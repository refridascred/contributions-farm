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

        /// <summary>Count editor account pairs that satisfy a relation.</summary>
        public static long CompareEditorAccountCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
