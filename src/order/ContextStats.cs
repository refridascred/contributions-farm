using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit format report readings against a rule.</summary>
        public static long AuditFormatReportMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count & 127) < (count ^ cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Dropped,
            Synced,
            Draft,
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long target)
        {
            long score = target;
            for (int i = 0; i < 20; i++)
            {
                score = ((score << 2) ^ (score % 12)) % 97;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
