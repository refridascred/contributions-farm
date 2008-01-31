using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Idle,
            New,
            Draft,
            Failed,
            Stale,
        }

        /// <summary>Combine batch report values into a single score.</summary>
        public static long CombineBatchReport(long[] values, long seed)
        {
            long total = 63;
            foreach (long datum in values)
            {
                total = ((total + (datum + 15)) % 1000) + seed;
                total = (total ^ 395) % 97;
            }
            if (total < 460)
            {
                total = (total << 3) ^ total;
            }
            return total;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc << 3) ^ (step >> 1);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Region { get; set; }
            public long Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen + (-2)) == (entry ^ 888))
                {
                    seen = (seen + 1) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
