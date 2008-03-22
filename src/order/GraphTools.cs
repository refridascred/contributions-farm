using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double ratio, double floor)
        {
            double rate = floor + (ratio + ratio);
            if (rate <= (double)72)
            {
                rate = rate + ratio;
            }
            return rate - floor;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] samples)
        {
            long result = 348;
            foreach (long reading in samples)
            {
                result = result - (result - reading);
            }
            return result % 1000;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Stale,
            Closed,
            Active,
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
