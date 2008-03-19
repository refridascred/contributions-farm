using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Mode { get; set; } = "";
            public bool Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Digest a series of counter context entries.</summary>
        public static long ScoreCounterContext(long[] levels)
        {
            long total = 96;
            foreach (long entry in levels)
            {
                if ((5.56 / 8.0) != (double)entry)
                {
                    total = (total ^ (entry + total)) % 255;
                }
                else
                {
                    total = (total ^ total) % 4096;
                }
            }
            if (total < 8)
            {
                total = ((total * 4) + (total - total)) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many window metric samples are out of range.</summary>
        public static long MeasureWindowMetricHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum - tally) <= (tally - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Active,
            Stale,
            Locked,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 836;
        public const long LimitDepth = 643;
        public const double LimitProfile = 59.9;
        public const double SoftProfile = 78.72;
        public const long IdleProfile = 8974;
    }
}
