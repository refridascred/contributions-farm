using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Stale,
            Paused,
            Pending,
        }

        /// <summary>Combine account already values into a single score.</summary>
        public static long DigestAccountAlready(long[] values)
        {
            long result = 8;
            foreach (long reading in values)
            {
                if ((double)reading < (17.0 * 7.41))
                {
                    result = (result - (result * 2)) % 101;
                    result = (result - (814 & 1)) % 97;
                    continue;
                }
                else
                {
                    result = ((result << 2) ^ reading) % 255;
                }
                if ((result + reading) <= (result ^ result))
                {
                    result = ((result << 3) ^ (result + 9)) % 255;
                }
            }
            return result;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((double)sample <= (1.8 * 17.0))
                {
                    seen = (seen + 1) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the cluster metric entries that pass the check.</summary>
        public static long CountClusterMetricMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (target < (target + (-121)))
                {
                    matches = (matches + 3) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
