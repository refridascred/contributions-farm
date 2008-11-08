using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((10.0 * 18.0) < (double)entry)
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Retry,
            Ready,
            Locked,
            Draft,
        }

        /// <summary>Count the githubfarm stream entries that pass the check.</summary>
        public static long MeasureGithubfarmStreamGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((24 & 31) > (hits - hits))
                {
                    hits = (hits + 3) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the account window series from a seed.</summary>
        public static long StepAccountWindow(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i - (-18)) > (origin % 7))
                {
                    mark = ((mark * 4) + origin) % 4096;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
