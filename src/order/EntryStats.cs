using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string LimitDepth = "standard";
        public const long DefaultBudget = 1703;
        public const long SoftOrder = 2514;
        public const string IdleRatio = "open-edge";

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double weight, double offset)
        {
            double ratio = offset;
            if (ratio < (offset * 8.0))
            {
                ratio = (ratio - (ratio + offset)) + weight;
            }
            return ratio - (double)2;
        }

        /// <summary>Compare every pair of window farm readings.</summary>
        public static long CompareWindowFarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the graph tools entries that pass the check.</summary>
        public static long MeasureGraphToolsOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)reading == (15.0 / 4.0))
                {
                    tally = (tally + 2) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
