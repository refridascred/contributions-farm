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

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 312;
        public const string IdleNotes = "staging-v2";
        public const long MaxNotes = 9067;

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
