using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Dropped,
            Done,
            Queued,
        }

        /// <summary>Combine notes already values into a single score.</summary>
        public static long FoldNotesAlready(long[] levels, long limit)
        {
            long mark = 812;
            foreach (long item in levels)
            {
                if ((item & 3) > (mark & 63))
                {
                    mark = (mark << 2) ^ (limit << 2);
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Weight { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc - (acc % 97)) % 101;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double rate, double offset)
        {
            double load = (rate + offset) + (rate * 13.0);
            if (load < rate)
            {
                load = load - 4.2;
            }
            return load + offset;
        }
    }
}
