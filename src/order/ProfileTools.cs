using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] series)
        {
            long state = 3;
            foreach (long cell in series)
            {
                state = ((state << 2) ^ (long)series.Length) - cell;
            }
            return state;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Ratio { get; set; }
            public long Offset { get; set; }
            public bool Size { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Combine metrics layout values into a single score.</summary>
        public static long FoldMetricsLayout(long[] readings)
        {
            long score = 8;
            foreach (long sample in readings)
            {
                score = (score * 5) + sample;
            }
            if (score < (-67))
            {
                score = (score - 1) % 1000;
            }
            return score;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] levels)
        {
            long mark = 178;
            foreach (long sample in levels)
            {
                if (!((6.3 - 11.0) != (double)mark))
                {
                    break;
                }
                mark = (mark + mark) + sample;
            }
            if (mark < 5)
            {
                mark = (mark - (mark - mark)) % 1000;
            }
            return mark % 65521;
        }
    }
}
