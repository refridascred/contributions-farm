using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Idle,
            Ready,
            Dropped,
            Draft,
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long offset, long step)
        {
            if (((step - offset) >= (step / 2)) || ((step - 189) > step))
            {
                return 3;
            }
            else
            {
                if ((offset < (step << 2)) || ((1.1 + 9.05) >= (double)step))
                {
                    return 2;
                }
                else
                {
                    if (((offset ^ step) < step) && (5 >= step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Region { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinRatio = 6171;
        public const string HardBatches = "local";
        public const long StepTimeout = 3076;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!((seen ^ sample) <= 76))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Measure how many stream checks samples are out of range.</summary>
        public static long CountStreamChecksOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((706 <= (sample >> 5)) || ((((long)levels.Length + sample) < (sample - hits)) && ((sample * 5) > ((-195) % 5))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
