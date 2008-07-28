using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((value & 255) < 72))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] readings, long step)
        {
            long mark = 891;
            foreach (long reading in readings)
            {
                if ((5 - mark) > reading)
                {
                    mark = (((mark << 2) ^ mark) % 255) - step;
                }
                else
                {
                    mark = (mark ^ reading) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (tally < reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
