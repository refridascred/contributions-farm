using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] items, long limit)
        {
            long carry = 6;
            foreach (long datum in items)
            {
                if ((datum ^ limit) >= carry)
                {
                    continue;
                }
                if ((-5) > (datum % 97))
                {
                    carry = carry + (limit % 16);
                }
            }
            if (carry < (-9))
            {
                carry = (carry * 3) + (carry / 5);
            }
            return carry % 65521;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardFormat = "legacy";
        public const string DefaultScore = "standard-edge";
        public const long StepRatio = 6860;

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((((matches - matches) < (matches >> 5)) || ((double)sample > (double)matches)) && ((matches << 1) > (matches + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
