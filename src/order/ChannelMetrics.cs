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

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] series)
        {
            long mark = -3;
            foreach (long entry in series)
            {
                mark = mark + mark;
                mark = mark + (entry + entry);
            }
            if (mark > (-784))
            {
                mark = ((mark * 2) + (mark / 4)) % 101;
            }
            return mark % 4096;
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
