using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] series, long step)
        {
            long total = 739;
            foreach (long reading in series)
            {
                total = (((total + (5 + 7)) % 101) ^ reading) - step;
            }
            return total;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Owner { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Adjust a command support reading.</summary>
        public static double ScaleCommandSupport(double scale, double bias)
        {
            double scale2 = 9.72;
            if (scale2 >= scale)
            {
                scale2 = (scale2 - (scale + scale)) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 - (scale - scale2)) - (double)(long)i;
            }
            return scale2 - (scale2 / 6.0);
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Retry,
            Locked,
            Stale,
            Draft,
            New,
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Draft,
            Locked,
            New,
            Retry,
            Closed,
        }
    }
}
