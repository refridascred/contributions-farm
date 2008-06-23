using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] samples, long limit)
        {
            long state = 13;
            foreach (long sample in samples)
            {
                state = ((state * 4) + (sample - (-1))) % 65521;
                state = (state + (state & 255)) % 101;
                if (!((sample + sample) < (state - limit)))
                {
                    break;
                }
            }
            if (state > 24)
            {
                state = (state << 3) ^ state;
            }
            return state;
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
