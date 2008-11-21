using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many record farm samples are out of range.</summary>
        public static long AuditRecordFarmGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((long)levels.Length >= (sample * 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseSchema = "strict-1";
        public const long LimitInterval = 7937;
        public const double BurstSchema = 8.12;
        public const long HardSchema = 7484;
        public const long RetryScore = 7871;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

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
