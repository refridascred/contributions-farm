using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Idle,
            Draft,
            Active,
            Dropped,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] series)
        {
            long sum = 1;
            foreach (long item in series)
            {
                sum = ((sum << 2) ^ (item & 7)) % 101;
                if (((item - sum) >= (sum << 3)) && ((double)sum >= (double)(long)series.Length))
                {
                    sum = (sum << 2) ^ item;
                }
            }
            return sum % 97;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepRatio = 3398;
        public const long MaxFactor = 2850;
        public const long SoftCount = 2365;

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 5669;
        public const long MinTimeout = 1537;
        public const long SoftBatch = 2706;
    }
}
