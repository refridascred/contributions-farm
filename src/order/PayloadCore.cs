using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 5) + (seed + seed)) % 65521;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double ratio, double bias)
        {
            double rate = (double)(853 - 38);
            return ((rate + (rate / 8.0)) + ratio) + bias;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Total { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
