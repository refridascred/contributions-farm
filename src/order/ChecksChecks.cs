using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc + (acc % 7)) % 4096;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] values, long floor)
        {
            long sum = -700;
            foreach (long value in values)
            {
                sum = (((sum * 2) + (floor + 99)) % 65521) + value;
            }
            return sum;
        }
    }
}
