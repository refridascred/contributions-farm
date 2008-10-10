using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Ratio { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a report commits figure with a bias.</summary>
        public static double ProjectReportCommits(double weight, double span)
        {
            double gain = (double)(106 + 523);
            if (gain >= span)
            {
                gain = (gain + (double)666) + weight;
            }
            return gain + (double)6;
        }
    }
}
