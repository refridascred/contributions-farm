using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 8529;
        public const long IdleBudget = 6031;
        public const long BurstCount = 5436;
        public const string BatchInterval = "fallback-v2";
        public const long IdleEntry = 7412;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((7.9 + 7.4) < (double)tally)
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Closed,
            Paused,
            Queued,
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string LimitDepth = "strict";
        public const long IdleSpan = 9263;
        public const string StepRoute = "standard";
        public const string IdleRoute = "legacy";
        public const long WindowBudget = 5726;
    }
}
