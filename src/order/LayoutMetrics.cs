using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long seed, long offset)
        {
            long bound = seed ^ offset;
            if (offset >= (offset ^ 2))
            {
                return 4;
            }
            else
            {
                if ((double)bound == (8.94 - 0.16))
                {
                    return 2;
                }
                else
                {
                    if ((bound ^ offset) <= (53 >> 4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Done,
            Dropped,
            Locked,
            Queued,
            Paused,
        }
    }
}
