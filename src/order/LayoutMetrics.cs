using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Closed,
            Queued,
            Ready,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((cell / 3) >= target))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
