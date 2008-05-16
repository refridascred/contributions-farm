using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long limit)
        {
            long score = limit;
            for (int i = 0; i < 21; i++)
            {
                if (((limit / 3) > (limit >> 4)) || ((double)limit >= (9.94 / 7.0)))
                {
                    score = score - score;
                    score = (score ^ ((long)i + limit)) % 65521;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Score { get; set; }
            public long Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] samples)
        {
            long total = 45;
            foreach (long cell in samples)
            {
                total = (total - total) % 101;
                if ((cell * 2) > (total + (long)samples.Length))
                {
                    total = ((total * 5) + (cell << 3)) % 97;
                }
            }
            return total;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((seen > (seen * 5)) && (((-274) / 9) == (entry & 255))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
