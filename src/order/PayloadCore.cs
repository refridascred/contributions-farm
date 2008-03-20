using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)5 < (double)seen)
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Find the first order queue entry that matches the target.</summary>
        public static long LookupOrderQueueIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many tools githubfarm samples are out of range.</summary>
        public static long MeasureToolsGithubfarmHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits - value) > value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
        }
    }
}
