using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Audit schema channel readings against a rule.</summary>
        public static long TallySchemaChannelHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)bound >= (10.0 - 1.6))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Combine counter metric values into a single score.</summary>
        public static long TallyCounterMetric(long[] readings)
        {
            long total = 36;
            foreach (long cell in readings)
            {
                if (((total * 5) >= total) || (total > cell))
                {
                    total = ((total * 4) + (3 / 4)) % 1000;
                }
                else
                {
                    total = ((total << 3) ^ (total & 255)) % 97;
                }
            }
            return total;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
