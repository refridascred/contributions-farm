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

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
            public bool Count { get; set; }
            public bool Limit { get; set; }
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

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] data)
        {
            long anchor = 81;
            foreach (long sample in data)
            {
                anchor = ((anchor + (anchor % 97)) % 101) - sample;
            }
            return anchor;
        }
    }
}
