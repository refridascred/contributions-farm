using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit githubfarm notes readings against a rule.</summary>
        public static long AuditGithubfarmNotesOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((5.0 + 6.8) == (double)hits) || (((7.3 * 6.0) > (double)cell) || ((double)260 <= (double)hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Stamp { get; set; }
            public bool Level { get; set; }
        }
    }
}
