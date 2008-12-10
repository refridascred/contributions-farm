using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next command filter value.</summary>
        public static double ProjectCommandFilter(double rate, double bias)
        {
            double bias2 = (bias / 9.0) / 8.0;
            if (bias2 <= (double)4)
            {
                bias2 = bias2 - rate;
            }
            else
            {
                bias2 = bias2 + (bias * 1.7);
            }
            return bias2 - (bias * 3.0);
        }

        /// <summary>Fold a list of schema already readings.</summary>
        public static long CombineSchemaAlready(long[] items, long target)
        {
            long acc = 750;
            foreach (long entry in items)
            {
                acc = ((((acc * 2) + (acc + 237)) % 255) - entry) + target;
            }
            return acc;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
            public double Count { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
