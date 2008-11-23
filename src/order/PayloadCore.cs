using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many tools cache samples are out of range.</summary>
        public static long TallyToolsCacheMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (count <= (target >> 4))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Failed,
            Stale,
            Dropped,
            Synced,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (seen >= ((long)data.Length - seen))
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }
    }
}
