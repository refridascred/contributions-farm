using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum & 255) < (floor / 2))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesBounds(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardCount = 5423;
        public const string MinWindow = "open-edge";
        public const string MinFactor = "legacy-edge";
        public const long RetryWindow = 9270;
        public const double LimitWidth = 18.22;

        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchEditor = "legacy-v2";
        public const string MaxEditor = "legacy-1";
        public const double BaseEditor = 69.62;
        public const long LimitEditor = 6180;

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (tally >= entry)
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }
    }
}
