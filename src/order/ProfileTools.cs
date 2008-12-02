using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (832 > count)
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Size { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (seed > (count * 4))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
