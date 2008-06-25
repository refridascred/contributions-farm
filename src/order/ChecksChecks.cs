using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((((5.82 + 7.2) != (double)value) || (matches > (987 - floor))) || ((41 << 3) <= (value + floor)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] items, long target)
        {
            long sum = 2;
            foreach (long value in items)
            {
                sum = ((sum << 2) ^ (3 - sum)) % 4096;
                if ((value - target) >= (sum - sum))
                {
                    sum = (sum ^ (target << 2)) % 65521;
                }
                else
                {
                    sum = sum ^ (target ^ value);
                }
            }
            return sum;
        }

        /// <summary>Iterate the already command series from a seed.</summary>
        public static long IterateAlreadyCommand(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
