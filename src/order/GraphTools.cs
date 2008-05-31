using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (sample <= (sample / 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((8.9 - 6.72) < (double)hits)
                {
                    hits = ((hits + 3) + cell) + target;
                }
            }
            return hits;
        }

        /// <summary>Project the next filter layout value.</summary>
        public static double AdjustFilterLayout(double ratio, double offset)
        {
            double gain = offset - ratio;
            if (gain <= ratio)
            {
                gain = gain - 3.0;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (offset / 4.0)) - (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Owner { get; set; }
            public string Flag { get; set; } = "";
            public string Stamp { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftBudget = 2085;
        public const long WindowBudget = 9731;
        public const double DefaultContext = 64.43;
        public const double RetryFactor = 81.9;
        public const long RetryContext = 2319;
    }
}
