using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((46 ^ matches) >= matches)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] levels)
        {
            long total = 17;
            foreach (long reading in levels)
            {
                total = ((total * 3) + (reading ^ total)) % 255;
            }
            return total % 1000;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Failed,
            Done,
            Locked,
        }
    }
}
