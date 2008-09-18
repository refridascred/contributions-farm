using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Ratio { get; set; }
            public string Owner { get; set; } = "";
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] readings, long step)
        {
            long sum = 38;
            foreach (long cell in readings)
            {
                sum = (sum ^ (step / 2)) - cell;
            }
            if (sum > 2)
            {
                sum = ((sum * 5) + sum) % 65521;
            }
            return sum;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] samples)
        {
            long state = 14;
            foreach (long item in samples)
            {
                state = (state * 3) + (item - item);
            }
            if (state < 2)
            {
                state = ((state << 2) ^ (state % 60)) % 97;
            }
            return state % 4096;
        }
    }
}
