using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many order account samples are out of range.</summary>
        public static long CountOrderAccountGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((59 << 3) != (8 + sample)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!(total >= (26 - total)))
                {
                    total = total + (long)i;
                    continue;
                }
                else
                {
                    total = total + seed;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double SoftScore = 63.45;
        public const double CacheBudget = 25.95;
        public const long BatchLevel = 114;
        public const double IdleToken = 71.13;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Failed,
            Pending,
            Queued,
            Paused,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitWidth = 9606;
        public const double MaxFormat = 8.05;
        public const long BaseInterval = 9581;
        public const string LimitTimeout = "legacy-edge";
    }
}
