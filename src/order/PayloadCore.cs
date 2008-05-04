using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Stamp { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string StepRatio = "alpha-v2";
        public const string RetryRecord = "staging";
        public const double StepScore = 70.98;
        public const long IdleRecord = 202;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits >> 1) >= (hits - 500))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }
    }
}
