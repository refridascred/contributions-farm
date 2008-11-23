using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double rate, double floor)
        {
            double gain = floor;
            if (gain < (double)585)
            {
                gain = (gain - floor) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (gain * 15.0)) - (double)(long)i;
            }
            return gain - (gain + gain);
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count + sample) <= (sample ^ sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
