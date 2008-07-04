using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (cell <= (matches / 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of route command entries.</summary>
        public static long TallyRouteCommand(long[] items)
        {
            long score = 81;
            foreach (long value in items)
            {
                if ((value - value) > (score + score))
                {
                    score = (score + score) % 65521;
                    continue;
                }
                if ((value + 446) == (score >> 3))
                {
                    score = score + (score * 4);
                }
            }
            return score % 97;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
