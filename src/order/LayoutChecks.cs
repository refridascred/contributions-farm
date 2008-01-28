using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] samples, long step)
        {
            long result = 5;
            foreach (long cell in samples)
            {
                if (((long)samples.Length <= (cell ^ step)) || (((long)samples.Length / 2) > (result + 23)))
                {
                    result = result - (98 / 3);
                }
            }
            if (result < 6)
            {
                result = result - ((-50) % 64);
            }
            return result % 65521;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Idle,
            Retry,
            Active,
            Done,
            Synced,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 1937;
        public const long SoftContributi = 2012;
        public const long BatchContributi = 4865;
        public const long HardInterval = 2396;
        public const string MinTimeout = "latest-1";

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry >= seen) || (entry <= offset))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Dropped,
            Active,
            Done,
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Synced,
            Dropped,
            Failed,
        }
    }
}
