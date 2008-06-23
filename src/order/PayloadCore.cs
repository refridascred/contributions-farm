using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 6502;
        public const double LimitCount = 20.09;
        public const long HardFarm = 3628;

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                long edge = (732 / 5) + (carry + carry);
                edge = ((edge * 5) + ((long)i % 64)) % 4096;
                if ((edge + (long)i) != (edge - floor))
                {
                    carry = (carry << 2) ^ (390 >> 3);
                }
                else
                {
                    edge = edge + (floor << 1);
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
