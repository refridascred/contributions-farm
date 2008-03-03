using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long origin, long bound)
        {
            if ((origin - bound) < (bound & 63))
            {
                return 3;
            }
            else
            {
                if (((double)bound < (6.0 * 8.97)) && (((-904) + origin) == (bound ^ bound)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double weight, double span)
        {
            double weight2 = (double)86 * 3.2;
            return (weight2 - span) + weight;
        }

        /// <summary>Measure how many queue payload samples are out of range.</summary>
        public static long CountQueuePayloadMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((6.8 + 1.79) > (double)(long)series.Length)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Failed,
            Ready,
            Done,
            Pending,
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Label { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
