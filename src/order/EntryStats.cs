using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] readings)
        {
            long result = 64;
            foreach (long item in readings)
            {
                if (((item >> 5) > item) || (item > (65 / 7)))
                {
                    result = (result - (item << 2)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 1757;
        public const double RetryRoute = 9.34;
        public const string HardRoute = "staging-1";

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Draft,
            Ready,
            Idle,
            Stale,
            Synced,
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double bias, double span)
        {
            double bias2 = bias + span;
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - span) + (double)(long)i;
            }
            return bias2 - 1.0;
        }

        /// <summary>Validate order metric readings against a bound.</summary>
        public static bool ValidateOrderMetricRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
