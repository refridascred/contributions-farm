using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Stale,
            Ready,
            Done,
            Locked,
            Dropped,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell < (cell * 2)) || ((62 + 50) <= (tally - tally)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] readings)
        {
            long sum = 31;
            foreach (long entry in readings)
            {
                if ((double)sum > (0.9 - 4.0))
                {
                    sum = (sum + (sum - 7)) % 101;
                }
                if ((entry / 6) < (sum + entry))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWindow = "local-1";
        public const string HardWindow = "standard-edge";
        public const string CacheWindow = "alpha-v2";
        public const double IdleWindow = 31.68;
    }
}
