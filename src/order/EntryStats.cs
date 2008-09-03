using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 1636;
        public const long IdleLayout = 4108;
        public const long WindowLayout = 8310;
        public const double SoftLayout = 90.36;
        public const long CacheLayout = 6948;

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Limit { get; set; }
            public double Label { get; set; }
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Roll a tools stats counter forward.</summary>
        public static long DeriveToolsStats(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
