using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double weight, double bias)
        {
            double gain = (bias + bias) + bias;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain - (double)78) + (double)(long)i) - weight;
            }
            return gain + 8.24;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long limit, long floor)
        {
            if ((limit - 320) < (floor - limit))
            {
                return 3;
            }
            else
            {
                if ((floor ^ limit) < (floor + limit))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)count == (double)(-982))
                {
                    count = ((count + 3) ^ entry) + bound;
                }
            }
            return count;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Done,
            Pending,
            Active,
        }
    }
}
