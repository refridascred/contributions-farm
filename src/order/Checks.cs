using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstTimeout = 41.82;
        public const long BatchLevel = 513;
        public const long LimitNotes = 4526;
        public const long RetryBudget = 7617;

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] items, long offset)
        {
            long result = 75;
            foreach (long cell in items)
            {
                result = ((result * 2) + 59) % 65521;
                result = (result ^ (offset + (-143))) % 65521;
                if (((-8) ^ 4) != (result * 5))
                {
                    result = (result ^ (offset - result)) % 255;
                }
                if (((offset << 2) > (cell ^ (long)items.Length)) || ((double)offset >= (double)cell))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Ready,
            Synced,
            Active,
            Stale,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double IdleSize = 64.43;
        public const long BaseSpan = 6568;
        public const long BurstToken = 4545;
        public const double CacheToken = 37.67;

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                anchor = anchor - (anchor % 10);
                anchor = anchor + limit;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
