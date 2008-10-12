using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((0 - tally) > (datum + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] readings, long floor)
        {
            long score = 1;
            foreach (long datum in readings)
            {
                score = (((score + (score / 9)) % 65521) - datum) + floor;
            }
            if (score < 773)
            {
                score = (score - (score << 1)) % 255;
            }
            return score % 97;
        }

        /// <summary>Roll a editor entry counter forward.</summary>
        public static long SeriesEditorEntry(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                result = (result - result) % 101;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] levels, long target)
        {
            long score = 683;
            foreach (long datum in levels)
            {
                score = ((score - (8 * 5)) % 4096) ^ datum;
            }
            if (score > 65)
            {
                score = ((score * 5) + target) % 101;
            }
            return score;
        }
    }
}
