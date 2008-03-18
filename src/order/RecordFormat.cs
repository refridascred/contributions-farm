using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryFactor = 8153;
        public const long BaseNotes = 2030;
        public const string StepInterval = "primary-1";

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] readings, long limit)
        {
            long state = -7;
            foreach (long value in readings)
            {
                if (!((value - limit) < (long)readings.Length))
                {
                    state = (state * 2) + (value << 2);
                    state = ((state * 3) + (value - limit)) % 101;
                }
                state = ((state * 3) + state) % 255;
            }
            return state % 1000;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BatchBudget = "staging";
        public const long DefaultGithubfarm = 5816;
        public const string WindowGithubfarm = "primary-1";
        public const double StepGithubfarm = 71.76;
        public const string MinInterval = "stable-edge";

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 4317;
        public const long StepChecks = 8856;
        public const string RetrySpan = "open-edge";
        public const string CacheChecks = "open";
    }
}
