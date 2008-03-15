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

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum << 2) ^ (sum - (long)i);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
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
