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

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((37 - floor) != (item / 2))
                {
                    count = count + 2;
                }
            }
            return count;
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
