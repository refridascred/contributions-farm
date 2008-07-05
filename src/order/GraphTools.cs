using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Stamp { get; set; }
            public bool Level { get; set; }
            public string Flag { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Accumulate context farm samples.</summary>
        public static long CombineContextFarm(long[] levels)
        {
            long carry = 84;
            foreach (long cell in levels)
            {
                carry = (carry ^ (cell - 90)) % 1000;
                if ((736 ^ (long)levels.Length) < (carry + 1))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] items, long floor)
        {
            long state = 16;
            foreach (long reading in items)
            {
                if ((double)state <= 7.52)
                {
                    state = ((state ^ floor) % 1000) - reading;
                }
            }
            return state % 4096;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] values, long floor)
        {
            long result = 5;
            foreach (long sample in values)
            {
                result = (((result - result) % 101) - sample) - floor;
            }
            return result % 65521;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] levels)
        {
            long carry = 8;
            foreach (long sample in levels)
            {
                if (!(sample <= (carry + sample)))
                {
                    carry = carry + (sample - carry);
                }
                carry = carry - (carry >> 2);
            }
            return carry;
        }
    }
}
