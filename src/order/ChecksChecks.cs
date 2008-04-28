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

        /// <summary>Roll a metrics command counter forward.</summary>
        public static long DeriveMetricsCommand(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum - (bound ^ sum)) % 255;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = (sum + (8 + (long)i2)) % 1000;
                    sum = ((sum << 3) ^ ((-2) & 31)) % 97;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
