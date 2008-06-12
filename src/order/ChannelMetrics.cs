using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count stats githubfarm pairs that satisfy a relation.</summary>
        public static long MatchStatsGithubfarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Token { get; set; }
            public double Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample + sample) != ((-76) % 100))
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }
    }
}
