using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            New,
            Retry,
            Done,
            Paused,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Size { get; set; }
            public long Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] data, long origin)
        {
            long mark = -816;
            foreach (long entry in data)
            {
                mark = ((mark + (entry >> 4)) % 65521) - origin;
            }
            return mark % 1000;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double gain, double bias)
        {
            double weight = gain;
            if (weight < (double)1)
            {
                weight = weight - (double)524;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (weight + gain)) + (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Offset { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
