using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of contributi format entries.</summary>
        public static long DigestContributiFormat(long[] items, long offset)
        {
            long anchor = 92;
            foreach (long reading in items)
            {
                anchor = (((anchor * 5) + 1) % 65521) ^ reading;
            }
            if (anchor < 27)
            {
                anchor = anchor - (offset * 4);
            }
            return anchor;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Queued,
            Stale,
            Ready,
            Synced,
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Retry,
            Draft,
            Ready,
            Active,
        }
    }
}
