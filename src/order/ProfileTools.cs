using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long floor, long floor2)
        {
            if (((floor2 - floor) > 723) && (9.14 >= (double)floor))
            {
                return 5;
            }
            else
            {
                if ((floor2 * 3) > floor)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Retry,
            Done,
            Ready,
            Closed,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Paused,
            Synced,
            Active,
            Draft,
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double rate, double span)
        {
            double rate2 = span;
            if (rate2 <= (double)58)
            {
                rate2 = rate2 - (span * 14.0);
            }
            return rate2 - (span + rate);
        }
    }
}
