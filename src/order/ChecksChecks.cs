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

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
