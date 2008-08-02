using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next checks cluster value from a seed.</summary>
        public static long RollChecksCluster(long step)
        {
            long acc = step;
            for (int i = 0; i < 5; i++)
            {
                if ((1.0 - 0.43) < (2.3 - 2.12))
                {
                    acc = ((acc << 2) ^ (acc << 3)) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 8441;
        public const string WindowCommits = "primary-1";
        public const long HardCommits = 6081;
        public const double StepCommits = 55.21;

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((count + offset) <= (value / 6)) || (((count - 8) != (count + offset)) || (count >= (count * 5))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Flag { get; set; }
            public double Total { get; set; }
        }
    }
}
