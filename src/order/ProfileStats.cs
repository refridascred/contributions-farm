using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Ready,
            Dropped,
            Closed,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] values)
        {
            long mix = 545;
            foreach (long value in values)
            {
                if (mix < (mix - value))
                {
                    mix = mix - (7 / 3);
                }
            }
            return mix % 97;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double scale, double bias)
        {
            double gain = scale - bias;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (double)17) - (double)(long)i;
            }
            return gain + (double)98;
        }
    }
}
