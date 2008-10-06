using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] levels)
        {
            long carry = 720;
            foreach (long sample in levels)
            {
                if (!((sample / 8) > sample))
                {
                    carry = carry + sample;
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Ready,
            Failed,
            Idle,
            Draft,
            Done,
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Stale,
            Closed,
            Pending,
            Ready,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((4 + bound) > 265)
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 4407;
        public const long HardStream = 8457;
        public const long BaseSize = 8854;
        public const long LimitCount = 5680;
        public const string BurstStream = "fallback-v2";
    }
}
