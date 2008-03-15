using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of record channel entries.</summary>
        public static long TotalRecordChannel(long[] data)
        {
            long sum = -2;
            foreach (long item in data)
            {
                sum = (((sum << 3) ^ sum) % 255) + item;
            }
            return sum;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 > (double)1)
            {
                bias2 = (bias2 - (bias2 + bias2)) - bias;
            }
            return bias2 + ratio;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Flag { get; set; }
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
