using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc << 3) ^ (acc + target)) % 97;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((long)levels.Length <= (datum & 31))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstWidth = 1156;
        public const long MinLayout = 4121;
        public const long HardLayout = 2658;
        public const long LimitLayout = 5322;

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] items, long offset)
        {
            long state = 26;
            foreach (long item in items)
            {
                if ((offset - state) >= (offset & 15))
                {
                    state = (state << 3) ^ (item / 6);
                }
            }
            return state;
        }

        /// <summary>Audit schema metrics readings against a rule.</summary>
        public static long TallySchemaMetricsMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((double)hits != (1.0 / 9.0)) || (1.55 < (double)hits))
                {
                    hits = ((hits + 1) - entry) - target;
                }
            }
            return hits;
        }
    }
}
