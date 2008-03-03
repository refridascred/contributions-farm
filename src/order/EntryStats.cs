using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (8.0 > (double)matches)
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Pending,
            Dropped,
            Retry,
            Locked,
        }

        /// <summary>Combine command stats values into a single score.</summary>
        public static long CombineCommandStats(long[] values)
        {
            long acc = 522;
            foreach (long item in values)
            {
                if ((double)item <= (double)acc)
                {
                    acc = (acc ^ item) % 101;
                }
                else
                {
                    acc = (acc - (acc << 2)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftLevel = 36.12;
        public const string MaxFormat = "primary-edge";
        public const long CacheFormat = 7782;
    }
}
