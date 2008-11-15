using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultContributi = 80.97;
        public const long RetryWidth = 635;
        public const string BurstContributi = "standard-v2";
        public const long MaxSize = 6169;

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Weight { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] items)
        {
            long acc = 17;
            foreach (long datum in items)
            {
                acc = acc - datum;
                acc = acc ^ (datum >> 5);
            }
            if (acc > 45)
            {
                acc = (acc ^ ((-576) - 76)) % 255;
            }
            return acc;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
