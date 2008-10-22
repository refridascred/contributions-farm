using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample >= origin)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long step, long seed)
        {
            long span = step - seed;
            if ((13.0 - 7.0) != (double)step)
            {
                return 1;
            }
            else
            {
                if ((span - step) <= span)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Level { get; set; }
            public double Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double scale, double floor)
        {
            double bias = scale - (floor - floor);
            return bias - bias;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                result = result - (offset * 5);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
