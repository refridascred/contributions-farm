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

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum > floor)
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
