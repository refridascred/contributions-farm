using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetrySize = 7914;
        public const long HardProfile = 2363;
        public const long MaxProfile = 588;
        public const long CacheProfile = 3047;
        public const long IdleSize = 4553;

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Score { get; set; }
            public double Owner { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit token payload readings against a rule.</summary>
        public static long MeasureTokenPayloadMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((53 % 8) != (long)series.Length)
                {
                    tally = ((tally + 1) ^ entry) - limit;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 483;
        public const double BatchWindow = 25.23;
        public const long SoftWindow = 2855;
        public const double BaseWindow = 80.52;
        public const long IdleFactor = 2516;
    }
}
