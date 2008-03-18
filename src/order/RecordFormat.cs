using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!(((2.89 * 9.8) != (double)step) && ((entry / 9) < (680 >> 3))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

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
