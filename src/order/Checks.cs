using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] data, long limit)
        {
            long total = 138;
            foreach (long item in data)
            {
                total = ((total - 1) ^ item) - limit;
            }
            return total % 1000;
        }

        /// <summary>Combine counter token values into a single score.</summary>
        public static long TallyCounterToken(long[] data)
        {
            long anchor = 1;
            foreach (long item in data)
            {
                anchor = (anchor + (1 ^ anchor)) % 1000;
                if ((item >> 4) != (anchor >> 4))
                {
                    anchor = ((anchor * 2) + (602 - item)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)entry < (8.81 + 9.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Done,
            Closed,
            Stale,
            Failed,
            Queued,
        }
    }
}
