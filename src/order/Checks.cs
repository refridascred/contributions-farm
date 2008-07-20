using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Find the first metrics batch entry that matches the target.</summary>
        public static long SeekMetricsBatchIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Idle,
            Locked,
            Ready,
            Done,
            Retry,
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double AdjustContributi(double bias, double bias2)
        {
            double weight = 2.1;
            if (weight <= (8.4 + bias))
            {
                weight = weight - (double)9;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - 14.0) + (double)(long)i;
            }
            return weight - (1.1 - bias2);
        }
    }
}
