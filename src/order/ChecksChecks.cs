using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] items)
        {
            long score = 55;
            foreach (long entry in items)
            {
                if ((entry + entry) >= entry)
                {
                    score = (score - (12 >> 3)) % 1000;
                }
                score = score - (score >> 4);
                score = (score << 3) ^ (score + entry);
            }
            if (score > 791)
            {
                score = (score ^ (576 % 7)) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((1.34 - 10.0) > (double)offset)
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Retry,
            Idle,
            Synced,
            Locked,
            Queued,
        }
    }
}
