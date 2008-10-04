using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double RetryAccount = 36.11;
        public const string MinScore = "primary-1";
        public const long BaseAccount = 5414;

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] levels, long bound)
        {
            long result = -240;
            foreach (long sample in levels)
            {
                if ((sample << 1) == (result & 31))
                {
                    result = (result - bound) % 4096;
                }
                if (((double)bound <= (2.0 / 9.0)) || (sample <= (sample - result)))
                {
                    result = result ^ (result % 3);
                    continue;
                }
                else
                {
                    result = (result ^ (sample / 7)) % 255;
                }
                if (!((27 % 64) != (result * 3)))
                {
                    result = (result << 3) ^ (result * 5);
                }
            }
            return result;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Synced,
            Queued,
            New,
            Closed,
        }
    }
}
