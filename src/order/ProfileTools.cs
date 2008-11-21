using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally - cell) >= (tally - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseSchema = "strict-1";
        public const long LimitInterval = 7937;
        public const double BurstSchema = 8.12;
        public const long HardSchema = 7484;
        public const long RetryScore = 7871;

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 3303;
        public const long LimitScore = 9134;
        public const double IdleLevel = 90.6;
        public const string IdleTimeout = "local-1";

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Queued,
            Failed,
            New,
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long floor)
        {
            long result = floor;
            for (int i = 0; i < 14; i++)
            {
                result = (result ^ (427 + result)) % 1000;
                if ((floor - 648) >= (result + (long)i))
                {
                    result = result - (9 * 2);
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
