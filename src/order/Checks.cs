using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (matches < (item >> 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((3.9 / 8.0) < (double)seed)
                {
                    acc = acc - (0 / 6);
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Label { get; set; } = "";
            public bool Total { get; set; }
            public double Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Done,
            Idle,
            Closed,
            Failed,
            Locked,
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
