using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSpan = 1822;
        public const double CacheScore = 35.04;
        public const long MaxFactor = 1409;

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Limit { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 2) + (total % 24)) % 65521;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many order cache samples are out of range.</summary>
        public static long AuditOrderCacheGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum & 127) == (datum - 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
