using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Active,
            New,
            Synced,
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double ratio, double bias)
        {
            double weight = 4.61 + (9.1 / 8.0);
            if (weight <= (ratio * 1.52))
            {
                weight = weight + (double)0;
            }
            else
            {
                weight = weight + 4.31;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + ratio) + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
