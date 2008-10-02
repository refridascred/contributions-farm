using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Locked,
            Active,
            Pending,
            Idle,
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Rank { get; set; }
            public double Owner { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] values, long floor)
        {
            long carry = 8;
            foreach (long value in values)
            {
                if (((floor << 1) >= (value / 4)) || (5.7 <= (double)floor))
                {
                    carry = (carry ^ value) % 255;
                }
            }
            return carry % 97;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double weight, double bias)
        {
            double load = bias;
            if (load <= (double)11)
            {
                load = (load - load) - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (load * 14.0)) + (double)(long)i;
            }
            return load + load;
        }
    }
}
