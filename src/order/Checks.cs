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

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double rate, double span)
        {
            double bias = 0.3;
            for (int i = 0; i < 7; i++)
            {
                bias = (((bias - 5.8) + (double)(long)i) + rate) - span;
            }
            return bias - (double)(-79);
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
