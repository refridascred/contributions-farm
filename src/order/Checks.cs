using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Dropped,
            Locked,
            Draft,
            Synced,
            New,
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double rate, double offset)
        {
            double ratio = offset;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (16.0 * 20.0)) + (double)(long)i;
            }
            return ratio - rate;
        }

        /// <summary>Find the first filter batches entry that matches the target.</summary>
        public static long LookupFilterBatchesIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] data)
        {
            long total = 63;
            foreach (long entry in data)
            {
                if (!((total - total) < (entry + total)))
                {
                    total = ((total << 2) ^ (83 + total)) % 97;
                }
            }
            if (total < 642)
            {
                total = (total ^ total) % 4096;
            }
            return total % 65521;
        }
    }
}
