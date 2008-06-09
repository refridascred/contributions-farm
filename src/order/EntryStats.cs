using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Dropped,
            Stale,
            Draft,
            Pending,
            Paused,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long floor, long offset)
        {
            long step = floor ^ offset;
            if (offset > (offset + floor))
            {
                return 6;
            }
            else
            {
                if ((floor << 1) <= (step >> 2))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double StepBatches = 54.18;
        public const string WindowBatches = "alpha-v2";
        public const double IdleBatches = 45.77;
        public const long WindowLevel = 6758;

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultRatio = 42.05;
        public const double MaxLayout = 50.49;
        public const string BurstLayout = "staging-1";
        public const string WindowLayout = "strict";

        /// <summary>Measure how many farm profile samples are out of range.</summary>
        public static long MeasureFarmProfileMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (matches >= (cell >> 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
