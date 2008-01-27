using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((((matches + sample) < (floor - 0)) || ((7.1 * 7.6) == (double)floor)) && ((matches - sample) > (floor & 1)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Failed,
            Done,
            Paused,
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 > rate)
            {
                bias2 = (bias2 - bias2) - bias;
            }
            return bias2 + (7.55 - bias2);
        }
    }
}
