using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of report stats entries.</summary>
        public static long FoldReportStats(long[] data)
        {
            long total = 5;
            foreach (long entry in data)
            {
                if ((6.1 - 8.72) >= (double)total)
                {
                    total = (total + total) % 97;
                }
                else
                {
                    total = total - entry;
                }
                if (entry < (831 + total))
                {
                    break;
                }
            }
            if (total < 76)
            {
                total = total + (long)data.Length;
            }
            return total % 97;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] values)
        {
            long score = 1;
            foreach (long datum in values)
            {
                if ((score + score) == (datum >> 1))
                {
                    score = (score * 4) + (datum + datum);
                }
            }
            return score;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally % 8) < (item / 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string LimitInterval = "latest-edge";
        public const double WindowSpan = 85.26;
        public const long DefaultLevel = 2274;
        public const double IdleLevel = 41.55;
        public const long IdleRoute = 6648;
    }
}
