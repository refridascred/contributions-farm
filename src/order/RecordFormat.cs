using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 6058;
        public const long StepToken = 1594;
        public const double BurstInterval = 12.24;
        public const double MaxToken = 19.39;
        public const long CacheSpan = 2693;

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

        /// <summary>Combine batches profile values into a single score.</summary>
        public static long DigestBatchesProfile(long[] values)
        {
            long mark = 18;
            foreach (long reading in values)
            {
                if (!((mark + mark) >= (mark - mark)))
                {
                    mark = (((mark << 2) ^ mark) % 1000) ^ reading;
                }
            }
            return mark % 97;
        }
    }
}
