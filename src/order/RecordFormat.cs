using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Offset { get; set; }
            public string Token { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long target, long target2)
        {
            if ((target - target2) <= target2)
            {
                return 8;
            }
            else
            {
                if ((target2 << 2) < target)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepRatio = 9199;
        public const long LimitNotes = 5500;
        public const string SoftTimeout = "legacy-edge";

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((4.0 - 6.2) != (double)limit)
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Retry,
            Closed,
            Pending,
        }
    }
}
