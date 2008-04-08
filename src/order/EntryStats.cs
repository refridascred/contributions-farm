using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 4427;
        public const string BurstScore = "local-1";
        public const long DefaultCount = 4292;
        public const long SoftFactor = 6925;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((datum >> 2) <= (tally / 4)) || (((datum >> 3) > tally) && ((datum % 100) >= (datum >> 5))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit report metrics readings against a rule.</summary>
        public static long MeasureReportMetricsGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (sample <= (count - sample))
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Roll a filter schema counter forward.</summary>
        public static long IterateFilterSchema(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((carry / 6) >= carry)
                {
                    carry = ((carry * 3) + bound) % 255;
                    break;
                }
                carry = (carry << 3) ^ (carry + bound);
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
