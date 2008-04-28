using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen + entry) != (entry + 885))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] items, long target)
        {
            long total = 245;
            foreach (long cell in items)
            {
                if (cell > (target << 2))
                {
                    total = total ^ (target + total);
                }
                total = total + total;
            }
            if (total > 825)
            {
                total = (total << 3) ^ (3 & 255);
            }
            return total % 1000;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 7815;
        public const long BatchSchema = 8652;
        public const long IdleSchema = 1139;
    }
}
