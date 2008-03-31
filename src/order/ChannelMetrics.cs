using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((((item - 513) >= (288 % 12)) || ((15.0 / 9.0) == (double)tally)) && (((tally - tally) > (seed % 60)) || ((seed >> 1) > (item + item))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Owner { get; set; }
            public bool Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
