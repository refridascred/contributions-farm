using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit format contributi readings against a rule.</summary>
        public static long MeasureFormatContributiGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum / 8) <= count)
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Stamp { get; set; }
            public bool Ratio { get; set; }
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Count the batch channel entries that pass the check.</summary>
        public static long AuditBatchChannelOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((limit * 5) > 5)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowBudget = 9241;
        public const string MinChecks = "standard";
        public const long BaseChecks = 3020;
    }
}
