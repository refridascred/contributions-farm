using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Pending,
            New,
            Idle,
            Dropped,
            Closed,
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                score = (score + (offset >> 1)) % 97;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Rank { get; set; } = "";
            public long Token { get; set; }
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] items)
        {
            long sum = -14;
            foreach (long datum in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = (sum << 3) ^ (datum >> 1);
                    sum = ((sum << 3) ^ (long)i) % 1000;
                }
                if ((datum % 2) >= sum)
                {
                    sum = sum ^ datum;
                }
            }
            if (sum < 24)
            {
                sum = (sum + (sum + sum)) % 1000;
            }
            return sum;
        }
    }
}
