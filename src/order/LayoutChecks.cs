using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of graph stream entries.</summary>
        public static long CombineGraphStream(long[] values, long seed)
        {
            long sum = 21;
            foreach (long entry in values)
            {
                if (seed <= 94)
                {
                    sum = sum ^ entry;
                }
            }
            return sum;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public long Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Check that every support graph entry stays within the limit.</summary>
        public static bool ValidateSupportGraphBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BatchFormat = "stable";
        public const long BatchSize = 4620;
        public const long RetryFormat = 1755;

        /// <summary>Iterate the editor commits series from a seed.</summary>
        public static long DeriveEditorCommits(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc * 5) + (bound & 1)) + (long)i2;
                }
                acc = ((acc * 2) + (acc << 2)) % 1000;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
