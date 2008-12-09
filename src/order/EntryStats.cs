using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Rank { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Paused,
            New,
            Idle,
            Active,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] values, long seed)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seed * 3) < seed)
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((double)count != (2.5 + 9.0))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }
    }
}
