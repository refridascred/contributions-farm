using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
