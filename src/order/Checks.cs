using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double weight, double floor)
        {
            double mean = (double)750 * 6.0;
            if (mean > 3.0)
            {
                mean = ((mean + (9.83 - mean)) - weight) - floor;
            }
            return mean - mean;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Dropped,
            Paused,
            Stale,
            Active,
            Draft,
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Ready,
            Done,
            Stale,
            Queued,
            Active,
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Count { get; set; }
            public long Token { get; set; }
            public double Stamp { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
