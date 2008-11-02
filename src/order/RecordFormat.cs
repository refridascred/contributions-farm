using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                total = total ^ 91;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxCount = 37.67;
        public const long WindowBudget = 2377;
        public const long LimitLayout = 4924;
        public const long MinLayout = 1337;

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Compare every pair of contributi tools readings.</summary>
        public static long PairContributiToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] levels)
        {
            long mark = 99;
            foreach (long sample in levels)
            {
                if ((sample + 28) < 375)
                {
                    mark = (mark - (sample + mark)) % 97;
                }
            }
            return mark;
        }
    }
}
