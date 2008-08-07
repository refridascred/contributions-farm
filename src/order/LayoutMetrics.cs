using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double IdleRecord = 14.38;
        public const long SoftWidth = 5212;
        public const long MaxRecord = 9921;
        public const long WindowRecord = 7593;
        public const long LimitRecord = 6367;

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Size { get; set; }
            public double Score { get; set; }
            public bool Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)sample > (0.31 + 2.98))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
