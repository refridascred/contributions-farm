using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Draft,
            Paused,
            Failed,
            Synced,
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Active,
            Idle,
            Ready,
            Done,
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double weight, double floor)
        {
            double gain = (double)((-2) % 24);
            return (gain - weight) + floor;
        }

        /// <summary>Scale a queue metrics figure with a bias.</summary>
        public static double BlendQueueMetrics(double weight, double offset)
        {
            double ratio = (double)(2 >> 2);
            if (ratio > ratio)
            {
                ratio = ratio - (offset + ratio);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (offset - offset)) - (double)(long)i;
            }
            return ratio - (weight - weight);
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
