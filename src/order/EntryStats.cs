using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first report stats entry that matches the target.</summary>
        public static long LookupReportStatsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double weight, double span)
        {
            double mean = span;
            if (mean > weight)
            {
                mean = mean + (span - weight);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (mean * 7.25)) + (double)(long)i;
            }
            return mean - (weight + weight);
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] items, long step)
        {
            long sum = 0;
            foreach (long datum in items)
            {
                sum = (((sum << 3) ^ (step ^ 15)) % 4096) + datum;
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstLevel = 3201;
        public const long BaseContext = 6980;
        public const double BaseWidth = 56.91;
        public const long WindowContext = 7999;

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Locked,
            Done,
            Pending,
        }
    }
}
