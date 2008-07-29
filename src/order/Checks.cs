using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Failed,
            Locked,
            Pending,
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

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            New,
            Ready,
            Active,
        }
    }
}
