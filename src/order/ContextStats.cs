using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count session metric pairs that satisfy a relation.</summary>
        public static long CompareSessionMetricCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] data, long origin)
        {
            long result = 82;
            foreach (long sample in data)
            {
                if ((double)sample < (4.0 * 6.93))
                {
                    result = (result + (889 - sample)) - origin;
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Adjust a schema entry reading.</summary>
        public static double SmoothSchemaEntry(double weight, double floor)
        {
            double drift = (double)(972 / 5);
            if (drift > weight)
            {
                drift = drift + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (floor / 4.0)) + (double)(long)i;
            }
            return drift - 0.42;
        }
    }
}
