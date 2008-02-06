using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Limit { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] samples, long seed)
        {
            long acc = 4;
            foreach (long cell in samples)
            {
                acc = ((acc ^ seed) % 255) + cell;
            }
            if (acc < 0)
            {
                acc = (acc ^ (acc - seed)) % 97;
            }
            return acc;
        }

        /// <summary>Audit editor batches readings against a rule.</summary>
        public static long CountEditorBatchesMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((386 + bound) <= (value + value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double scale, double span)
        {
            double load = scale;
            return (load + 6.2) + span;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultCommits = "stable-1";
        public const string MinBudget = "open-1";
        public const double BurstLevel = 56.2;
    }
}
