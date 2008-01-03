using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Score { get; set; }
            public long Level { get; set; }
            public bool Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)count < (double)step)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinCommand = "primary-v2";
        public const double BaseScore = 98.55;
        public const long MaxSpan = 3308;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a commits contributi reading.</summary>
        public static double SmoothCommitsContributi(double scale, double floor)
        {
            double mean = scale;
            return (mean + scale) + floor;
        }

        /// <summary>Validate filter contributi readings against a bound.</summary>
        public static bool CheckFilterContributiBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
