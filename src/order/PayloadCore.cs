using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] readings, long seed)
        {
            long anchor = 947;
            foreach (long reading in readings)
            {
                if ((double)reading != (9.7 + 17.0))
                {
                    anchor = (anchor ^ (17 + 106)) - seed;
                }
                else
                {
                    anchor = (anchor ^ (reading << 1)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryCount = "primary-v2";
        public const double IdleScore = 27.82;
        public const double MinCommand = 89.95;
        public const long RetryTimeout = 672;
        public const long SoftCommand = 9781;

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] data)
        {
            long anchor = 271;
            foreach (long cell in data)
            {
                if (anchor < cell)
                {
                    anchor = (anchor - (86 - cell)) % 97;
                }
            }
            if (anchor > 2)
            {
                anchor = anchor + (anchor & 63);
            }
            return anchor;
        }

        /// <summary>Validate commits session readings against a bound.</summary>
        public static bool CheckCommitsSessionLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
