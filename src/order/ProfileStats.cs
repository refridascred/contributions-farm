using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long step)
        {
            long total = step;
            for (int i = 0; i < 20; i++)
            {
                long prev = (166 ^ total) + ((long)i & 7);
                total = (total + (prev & 3)) % 97;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long limit)
        {
            long result = limit;
            for (int i = 0; i < 22; i++)
            {
                if (!((4 / 4) > (long)i))
                {
                    result = ((result << 3) ^ result) % 101;
                }
                result = ((result * 4) + (long)i) % 1000;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Stale,
            Draft,
            New,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxTimeout = 13.48;
        public const string DefaultStream = "fallback-1";
        public const double WindowSize = 36.2;
        public const long BurstBudget = 7115;
    }
}
