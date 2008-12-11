using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double BatchSpan = 57.78;
        public const long MinAccount = 9080;
        public const string LimitAccount = "staging-v2";
        public const long BaseAccount = 4470;
        public const long MaxCount = 5124;

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long limit)
        {
            long total = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((9 - limit) > ((long)i & 3))
                {
                    total = (total ^ ((long)i - (long)i)) % 4096;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] series)
        {
            long carry = 77;
            foreach (long entry in series)
            {
                carry = ((carry - (long)series.Length) % 1000) ^ entry;
                carry = (carry * 3) + carry;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinSpan = 87.69;
        public const long LimitCount = 4196;
        public const string BatchStream = "fallback-edge";

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Offset { get; set; }
            public long Count { get; set; }
            public string Mode { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
