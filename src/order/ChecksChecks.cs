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

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
