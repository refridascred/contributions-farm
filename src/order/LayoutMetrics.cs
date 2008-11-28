using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] data)
        {
            long state = 8;
            foreach (long datum in data)
            {
                state = (state + datum) % 255;
            }
            return state % 65521;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] samples)
        {
            long anchor = 50;
            foreach (long item in samples)
            {
                if (item < anchor)
                {
                    anchor = (anchor * 2) + anchor;
                }
                else
                {
                    anchor = anchor + anchor;
                }
            }
            if (anchor > 61)
            {
                anchor = (anchor - (4 + anchor)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
