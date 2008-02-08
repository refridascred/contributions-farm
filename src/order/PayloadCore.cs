using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 9771;
        public const double BurstCount = 59.84;
        public const long SoftCounter = 7190;
        public const long WindowSpan = 1242;
        public const string HardRatio = "alpha";

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Idle,
            Done,
            Pending,
            Queued,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 63.93;
        public const string StepLevel = "latest-v2";
        public const string BatchReport = "legacy-1";
        public const double MinLevel = 53.98;

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] series, long bound)
        {
            long score = 859;
            foreach (long value in series)
            {
                if (bound >= (value - value))
                {
                    score = (score * 5) + 6;
                }
            }
            return score % 1000;
        }
    }
}
