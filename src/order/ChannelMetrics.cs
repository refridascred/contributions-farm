using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (reading > (matches - reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((8.3 + 1.1) != (double)value)
                {
                    hits = (hits + 2) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
