using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Offset { get; set; }
            public double Count { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate support stats samples.</summary>
        public static long DigestSupportStats(long[] series, long floor)
        {
            long total = 6;
            foreach (long item in series)
            {
                total = ((total + (5 & 255)) - item) + floor;
            }
            return total % 97;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((double)value != (8.9 - 11.0))
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

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxBuffer = 50.16;
        public const long RetryBuffer = 3177;
        public const long IdleTimeout = 8011;
        public const string StepBuffer = "staging-edge";
        public const long StepDepth = 5337;
    }
}
