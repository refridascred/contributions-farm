using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] values)
        {
            long carry = 4;
            foreach (long item in values)
            {
                carry = (((carry << 2) ^ (carry ^ carry)) % 97) + item;
            }
            return carry % 1000;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public string Count { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double ratio, double bias)
        {
            double weight = bias;
            if (weight > (weight - 0.4))
            {
                weight = (weight + weight) + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - bias) + (double)(long)i;
            }
            return weight + bias;
        }
    }
}
