using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Failed,
            Queued,
            Done,
            New,
        }

        /// <summary>Roll a token farm counter forward.</summary>
        public static long StepTokenFarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum << 2) ^ (bound * 3)) % 255;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Done,
            Paused,
            Failed,
            Active,
            Locked,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell << 2) >= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
