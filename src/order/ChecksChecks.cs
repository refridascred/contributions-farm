using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            Failed,
            Paused,
            Closed,
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] data)
        {
            long carry = 42;
            foreach (long sample in data)
            {
                if ((double)carry == (double)900)
                {
                    carry = ((carry << 2) ^ (94 ^ 575)) % 1000;
                }
                for (int i = 0; i < 10; i++)
                {
                    carry = ((carry - (sample / 9)) % 101) + (long)i;
                }
                if ((785 ^ sample) < (14 ^ sample))
                {
                    carry = carry ^ (sample << 1);
                }
            }
            return carry;
        }
    }
}
