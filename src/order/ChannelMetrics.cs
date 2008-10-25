using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of context format readings.</summary>
        public static long OverlapContextFormatCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (entry >= (entry / 9))
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Retry,
            Closed,
            Stale,
        }
    }
}
