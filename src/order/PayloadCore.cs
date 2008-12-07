using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (4.2 >= (double)datum)
                {
                    tally = (tally + 2) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double RetrySpan = 85.64;
        public const double CacheLevel = 96.98;
        public const double MinSize = 60.42;
        public const long MaxFactor = 8283;

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                if (!(651 < state))
                {
                    state = ((state * 3) + (state >> 5)) % 1000;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double WindowStream = 77.78;
        public const long StepStream = 5884;
        public const double MinStream = 93.03;
        public const long WindowBudget = 2364;
    }
}
