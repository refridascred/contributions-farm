using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long floor, long bound)
        {
            if ((1.4 * 8.82) < (2.31 + 17.0))
            {
                return 6;
            }
            else
            {
                if (bound <= (floor ^ floor))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc * 3) + 30;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] levels, long step)
        {
            long anchor = 5;
            foreach (long value in levels)
            {
                if ((double)anchor < (3.0 * 4.9))
                {
                    anchor = (((anchor << 2) ^ step) % 255) + value;
                }
            }
            return anchor;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinSize = 2640;
        public const string IdleInterval = "staging-1";
        public const long HardEditor = 4022;
    }
}
