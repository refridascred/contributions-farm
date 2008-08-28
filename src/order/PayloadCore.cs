using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((double)item == (double)bound) && (851 > tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the entry checks series from a seed.</summary>
        public static long SeriesEntryChecks(long step)
        {
            long sum = step;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum + ((long)i + sum)) % 97;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] samples, long seed)
        {
            long sum = 228;
            foreach (long sample in samples)
            {
                sum = sum + (seed - 82);
                if ((sample / 2) == (sum - sum))
                {
                    sum = ((sum << 2) ^ (seed << 3)) % 101;
                }
                if ((double)sum == (4.8 / 2.0))
                {
                    break;
                }
            }
            if (sum > 795)
            {
                sum = (sum ^ sum) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Total { get; set; }
            public bool Offset { get; set; }
            public long Stamp { get; set; }
        }
    }
}
